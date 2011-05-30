﻿using System;
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
    public partial class RelationsForm : Form
    {
        public RelationsForm()
        {
            InitializeComponent();
            relsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
        }

        private void RelationsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'relsDataSet.rels' table. You can move, or remove it, as needed.
            this.relsTableAdapter.Fill(this.relsDataSet.rels);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AddRelation()).ShowDialog();
            this.relsTableAdapter.Fill(this.relsDataSet.rels);
    
        }

    
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter mDA = relsTableAdapter.Adapter;
            DataSet mDS = relsDataSet;
            
            int ri = relsGrid.SelectedCells[0].RowIndex;
            string id = mDS.Tables["rels"].Rows[ri]["id"].ToString();
            
            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"delete from [relationships] where id=@id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                command.ExecuteNonQuery();
            }
            this.relsTableAdapter.Fill(this.relsDataSet.rels);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(null, null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteToolStripMenuItem_Click(null, null);
        }
    }
}
