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


namespace RegressionViewer.Forms
{
    public partial class AddRelation : Form
    {
        public AddRelation()
        {
            InitializeComponent();
            modulesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            filesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
        }

        private void AddRelation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filesDataSet.filesGridViewColumn' table. You can move, or remove it, as needed.
            this.modulesTableAdapter.Fill(this.usesModulesDataSet.modules);
            fillFilesUsingParametrizedQuery(usesModuleCombo, null);
            this.modulesTableAdapter.Fill(this.usedModulesDataSet.modules);
            fillFilesUsingParametrizedQuery(usedModuleCombo, null);
        }

        private void fillFilesUsingParametrizedQuery(object sender, EventArgs e)
        {
            try
            {
                if (sender.Equals(usesModuleCombo))
                    this.filesTableAdapter.FillBy1(this.usesFilesDataSet.files, new System.Nullable<long>(((long)(System.Convert.ChangeType(usesModuleCombo.SelectedValue, typeof(long))))));
                else if (sender.Equals(usedModuleCombo))
                    this.filesTableAdapter.FillBy1(this.usedFilesDataSet.files, new System.Nullable<long>(((long)(System.Convert.ChangeType(usedModuleCombo.SelectedValue, typeof(long))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"Insert into [relationships] (uses,used,rate) values (@uses,@used,@rate)";
                command.Parameters.Add(new SQLiteParameter("@uses", usesNameCombo.SelectedValue));
                command.Parameters.Add(new SQLiteParameter("@used", usedNameCombo.SelectedValue));
                command.Parameters.Add(new SQLiteParameter("@rate", rateUpDown.Value));
                command.ExecuteNonQuery();
            }
            
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
