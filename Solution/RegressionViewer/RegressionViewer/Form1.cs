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

namespace RegressionViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string baseName = "Program.db3";
            ConnectionManager.filename = baseName;
            string folder = "C:\\Bakalavr\\Solution\\RegressionViewer\\RegressionViewer\\bin";

            SQLiteConnection.CreateFile(baseName);
            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                {
                    command.CommandText = @"drop TABLE if exists folders;";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                {
                    command.CommandText = @"drop TABLE if exists files;";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                {
                    command.CommandText = @"CREATE TABLE [folders] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [p_id] integer,
                    [name] char(255) NOT NULL,
                    FOREIGN KEY (p_id) REFERENCES folders (id)
                    );";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"CREATE TABLE [modules] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [name] char(255) NOT NULL
                    );";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                {
                    command.CommandText = @"CREATE TABLE [files] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [p_id] integer NOT NULL,
                    [name] char(255) NOT NULL,
                    [module_id] integer,
                    FOREIGN KEY (p_id) REFERENCES folders (id)
                    FOREIGN KEY (module_id) REFERENCES modules (id)
                    );";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                AddDirectoriesRecursively(folder, null);
              
            InitializeComponent();
        }

        public void AddDirectoriesRecursively(string folder, int? p_id)
        {
            DirectoryInfo di = new DirectoryInfo(folder);

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"Insert into [folders] (p_id,name) values (@p_id,@name); SELECT last_insert_rowid() AS [ID]";
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@p_id", p_id == null ? "null" : p_id.ToString()));
                command.Parameters.Add(new SQLiteParameter("@name", di.Name));
                p_id = int.Parse(command.ExecuteScalar().ToString());
            }

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"Insert into [files] (p_id,name) values (@p_id,@name)";
                command.CommandType = CommandType.Text;
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
            treeViewAdv1.Model = new SlowTreeModel();
        }

        private void _nodeModule_ChangesApplied(object sender, EventArgs e)
        {
            
        }

        
    }
}


