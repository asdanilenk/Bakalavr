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
            string baseName = "Program.db3";
            string folder = "C:\\Bakalavr\\Solution\\RegressionViewer\\RegressionViewer\\bin";
            
            ConnectionManager.filename = baseName;
            
            //SQLiteConnection.CreateFile(baseName);
            //ConnectionManager.CreateDB();
            //AddDirectoriesRecursively(folder, null);
           
            ConnectionManager.ExecuteNonQuery("PRAGMA foreign_keys = true;");
            InitializeComponent();
            this.modulesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            
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

        private void TreeView_Load(object sender, EventArgs e)
        {
            this.modulesTableAdapter.Fill(this.programDataSet.modules);
            
            treeView.Model = new SlowTreeModel();

            UpdateModulesDropDown();

            
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
            DataSet mDS = programDataSet;
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
            modulesTableAdapter.Fill(programDataSet.modules);
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

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new RelationshipsForm()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new GraphForm()).ShowDialog();
        }

       /* private void deleteModulesContextMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            modulesView.Rows.RemoveAt(modulesView.SelectedCells[0].RowIndex);
        }*/
    }
}


