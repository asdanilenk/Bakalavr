using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using Aga.Controls.Tree;
using Aga.Controls.Tree.NodeControls;
using Aga.Controls;

namespace RegressionViewer.Forms
{
    public partial class TreeForm : Form
    {
        public TreeForm()
        {
            InitializeComponent();
            this.patchesStripComboBox.ComboBox.BindingContext = this.BindingContext;
            this.patchesStripComboBox.ComboBox.DataSource = patchesBindingSource;
            this.patchesStripComboBox.ComboBox.ValueMember = "id";
            this.patchesStripComboBox.ComboBox.DisplayMember = "name";

            this.DeletePatchToolStripMenuCombo.ComboBox.BindingContext = this.BindingContext;
            this.DeletePatchToolStripMenuCombo.ComboBox.DataSource = patchesDelBindingSource;
            this.DeletePatchToolStripMenuCombo.ComboBox.ValueMember = "id";
            this.DeletePatchToolStripMenuCombo.ComboBox.DisplayMember = "name";
        }

        

        public void AddDirectoriesRecursively(string folder, int? p_id)
        {
            DirectoryInfo di = new DirectoryInfo(folder);

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"Insert into [folders] (p_id,name) values (@p_id,@name); SELECT last_insert_rowid() AS [ID]";
                command.Parameters.Add(new SQLiteParameter("@p_id", p_id == null ? "null" : p_id.ToString()));
                command.Parameters.Add(new SQLiteParameter("@name", di.Name));
                p_id = int.Parse(command.ExecuteScalar().ToString());
            }

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"Insert into [files] (p_id,name) values (@p_id,@name)";
                SQLiteParameter _name = new SQLiteParameter("@name");
                command.Parameters.Add(_name);
                command.Parameters.Add(new SQLiteParameter("@p_id", p_id));

                foreach (FileInfo cfi in di.GetFiles())
                {
                    _name.Value = cfi.Name;
                    command.ExecuteNonQuery();
                }
            }

            foreach (DirectoryInfo cdi in di.GetDirectories())
                AddDirectoriesRecursively(cdi.FullName, p_id);
        }

        private void UpdateModulesDropDown()
        {
            treeNodeModule.DropDownItems.Clear();
            treeNodeModule.DropDownItems.Add("");

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"select name from modules";
                
                SQLiteDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                    treeNodeModule.DropDownItems.Add(DataReader["name"]);
            }
        }
        
        private void _nodeModule_ChangesApplied(object sender, EventArgs e)
        {
            (sender as NodeComboBox).Parent.SelectedNode.Expand();
        }


        private void applyButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection mCN = ConnectionManager.connection;
            SQLiteDataAdapter mDA = modulesTableAdapter.Adapter;
            SQLiteCommandBuilder mCB = new SQLiteCommandBuilder(mDA);
            DataSet mDS = modulesDataSet;
            DataSet dsChanges = new DataSet();
            if (!mDS.HasChanges()) return;
            dsChanges = mDS.GetChanges(DataRowState.Modified);
            if (dsChanges != null)
            {
                mDA.UpdateCommand = mCB.GetUpdateCommand();
                mDA.Update(dsChanges, "modules");
            }
            dsChanges = mDS.GetChanges(DataRowState.Added);
            if (dsChanges != null)
            {
                mDA.InsertCommand = mCB.GetInsertCommand();
                mDA.Update(dsChanges, "modules");
            }
            dsChanges = mDS.GetChanges(DataRowState.Deleted);
            if (dsChanges != null)
            {
                mDA.DeleteCommand = mCB.GetDeleteCommand();
                mDA.Update(dsChanges, "modules");
            }
            mDS.AcceptChanges();
            UpdateModulesDropDown();
            (treeView.Model as SlowTreeModel).Root.UpdateModulesFromDbRec();
            treeView.Invalidate();
        }

        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            modulesTableAdapter.Fill(modulesDataSet.modules);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                Node parent = treeView.SelectedNode.Parent.Tag as Node;
                List<string> parents = new List<string>();
                while (parent != null)
                {
                    parents.Add(parent.ToString());
                    parent = parent.Parent;
                }
                parents.Reverse();

                NodeModule nm = treeView.SelectedNode.Tag as NodeModule;
                string id = nm.Tag.ToString();
                if (id.StartsWith("f"))
                {
                    using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                    {
                        command.CommandText = @"delete from files where id=@id";
                        command.Parameters.Add(new SQLiteParameter("@id", id.Substring(1)));
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                    {
                        command.CommandText = @"delete from folders where id=@id";
                        command.Parameters.Add(new SQLiteParameter("@id", id));
                        command.ExecuteNonQuery();
                    }
                }

                treeView.Model = new SlowTreeModel();
                TreePath tp = new TreePath();
                treeView.FindNode(tp).Expand();

                for (int i = 0; i < parents.Count; i++)
                {
                    tp = new TreePath(tp, parents[i]);
                    treeView.FindNode(tp).Expand();
                }
            }
        }

        private void treeViewAdv1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
                deleteToolStripMenuItem_Click(null, null);
        }

        private void deleteModulesContextMenuItem_Click(object sender, EventArgs e)
        {
            modulesView.Rows.RemoveAt(modulesView.SelectedCells[0].RowIndex);
        }

        private void patchesStripComboBox_Click(object sender, EventArgs e)
        {
            if (patchesToolStripMenuItem.DropDown.Visible == true)
            {
                ToolStripComboBox cb = sender as ToolStripComboBox;
                if (cb.ComboBox.SelectedValue != null)
                {
                    patchesToolStripMenuItem.DropDown.Hide();
                    (new GraphForm(int.Parse(cb.ComboBox.SelectedValue.ToString()))).ShowDialog();
                }
            }
        }

        private void addPatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AddPatch()).ShowDialog();
            this.patchesTableAdapter.Fill(this.patchesDataSet.patches);
        }

        private void filesRelationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new RelationsForm()).ShowDialog();
        }

        private void modulesGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new GraphForm()).ShowDialog();
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Multiselect = false;
            ofp.Filter = "sqlite3 files|*.db3";
            ofp.FilterIndex = 1;
            ofp.RestoreDirectory = true;
            

            if (ofp.ShowDialog() == DialogResult.OK)
            {
                string baseName = ofp.FileName;
                ConnectionManager.filename = baseName;
                setupView();
            }            
        }

        private void setupView()
        {
            ConnectionManager.ExecuteNonQuery("PRAGMA foreign_keys = true;");
            this.modulesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.patchesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            mainPanel.Enabled = true;
            this.patchesTableAdapter.Fill(this.patchesDataSet.patches);
            this.modulesTableAdapter.Fill(this.modulesDataSet.modules);
            treeView.Model = new SlowTreeModel();
            UpdateModulesDropDown();
        }

        private void mainPanel_EnabledChanged(object sender, EventArgs e)
        {

            foreach (System.Windows.Forms.Control ctrl in mainPanel.Controls)
            {
                ctrl.Enabled = mainPanel.Enabled;
            }
            patchesToolStripMenuItem.Enabled = mainPanel.Enabled;
            relationsToolStripMenuItem.Enabled = mainPanel.Enabled;
        }

        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.patchesDataSet.patches.Clear();
            this.modulesDataSet.modules.Clear();
            treeView.Model = null;
            mainPanel.Enabled = false;    
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Select file to save project data";
            sfd.Filter = "sqlite3 files|*.db3";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Select the project sources root directory:";
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string baseName = sfd.FileName;
                    ConnectionManager.filename = baseName;
                    SQLiteConnection.CreateFile(baseName);
                    ConnectionManager.CreateDB();
                
                    AddDirectoriesRecursively(fbd.SelectedPath, null);
                    setupView();
                }
                
            }
        }

        private void DeletePatchToolStripMenuCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (patchesToolStripMenuItem.DropDown.Visible == true)
            {
                patchesToolStripMenuItem.DropDown.Hide();
                if (MessageBox.Show("Do you want to delete '" + DeletePatchToolStripMenuCombo.ComboBox.Text + "'?",
                                "Delete patch",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                    {
                        command.CommandText = @"delete from patches where id=@id";
                        command.Parameters.Add(new SQLiteParameter("@id", DeletePatchToolStripMenuCombo.ComboBox.SelectedValue));
                        command.ExecuteNonQuery();
                    }
                    patchesTableAdapter.Fill(patchesDataSet.patches);
                }
            }
        }
        

        

    }
}


