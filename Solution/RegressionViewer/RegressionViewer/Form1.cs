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
using TriStateTreeView.TriStateTreeView;

namespace RegressionViewer
{
    public partial class Form1 : Form
    {
        string baseName = "Program.db3";

        public Form1()
        {
            SQLiteConnection con = new SQLiteConnection();
            string baseName = "Program.db3";
            string folder = "C:\\Bakalavr\\";
            /*
            SQLiteConnection.CreateFile(baseName);

            SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
            using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
            {
                connection.ConnectionString = "Data Source = " + baseName;
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"drop TABLE if exists folders;";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"drop TABLE if exists files;";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

                using (SQLiteCommand command = new SQLiteCommand(connection))
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
                
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"CREATE TABLE [files] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [p_id] integer NOT NULL,
                    [name] char(255) NOT NULL,
                    FOREIGN KEY (p_id) REFERENCES folders (id)
                    );";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                AddDirectoriesRecursively(folder, null, connection);
                
                
            }
            */

            InitializeComponent();
        }

        public void AddDirectoriesRecursively(string folder,int? p_id, SQLiteConnection connection)
        {
            DirectoryInfo di = new DirectoryInfo(folder);
            
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = @"Insert into [folders] (p_id,name) values (@p_id,@name); SELECT last_insert_rowid() AS [ID]";
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@p_id",p_id == null ? "null" : p_id.ToString()));
                command.Parameters.Add(new SQLiteParameter("@name", di.Name));
                p_id = int.Parse(command.ExecuteScalar().ToString());
            }

            using (SQLiteCommand command = new SQLiteCommand(connection))
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
                AddDirectoriesRecursively(cdi.FullName, p_id, connection);
            
            
        }

        private void TreeView_Load(object sender, EventArgs e)
        {
                Aga.Controls.Tree.TreeModel tm = new Aga.Controls.Tree.TreeModel();
                Aga.Controls.Tree.Node np ;

            TreeNode nodeParent;

            SQLiteConnection con = new SQLiteConnection();

            SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
            using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
            {
                connection.ConnectionString = "Data Source = " + baseName;
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"select * from folders where p_id='null';";
                    command.CommandType = CommandType.Text;
                    SQLiteDataReader DataReader =  command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        ImageList myImageList = new ImageList();
                        myImageList.Images.Add(System.Drawing.Image.FromFile("StateNone16.ico"));
                        myImageList.Images.Add(System.Drawing.Image.FromFile("StateUnchecked16.ico"));
                        myImageList.Images.Add(System.Drawing.Image.FromFile("StateChecked16.ico"));
                        myImageList.Images.Add(System.Drawing.Image.FromFile("StateIndeterminate16.ico"));
                        ImageList myIconsList = new ImageList();
                        myIconsList.Images.Add(System.Drawing.Image.FromFile("ImageComputer16.ico"));
                        myIconsList.Images.Add(System.Drawing.Image.FromFile("ImageFolder16.ico"));
                        myIconsList.Images.Add(System.Drawing.Image.FromFile("ImageFile16.ico"));
                        
                        triStateTreeView1.SetImagesList(myImageList);
                        triStateTreeView1.ImageList = myIconsList;
                        nodeParent = triStateTreeView1.AddTreeNode(triStateTreeView1.Nodes,DataReader["name"].ToString(),1,CheckBoxState.Checked);
                        nodeParent.Tag = DataReader["id"];
                        triStateTreeView1.AddTreeNode(triStateTreeView1.FindByTag(nodeParent.Tag).Nodes, "*", 1, CheckBoxState.Checked);

                        nodeParent = treeView1.Nodes.Add(DataReader["name"].ToString());
                        nodeParent.ImageIndex = 0;
                        nodeParent.Tag = DataReader["id"];
                        nodeParent.Nodes.Add("*");

                        treeViewAdv1.BeginUpdate();
                        treeViewAdv1.NodeControls.Add(new Aga.Controls.Tree.NodeControls.NodeTextBox());

                        treeViewAdv1.Model = tm;
                        np = new Aga.Controls.Tree.Node(DataReader["name"].ToString());
                        tm.Nodes.Add(np);
                        np.Nodes.Add(new Aga.Controls.Tree.Node("*"));
                        
                        
                        treeViewAdv1.EndUpdate();
                        
                    }
                }
            }
    }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

            TreeNode nodeSelected, nodeChild;
            nodeSelected = e.Node;


            if (nodeSelected.Nodes[0].Text == "*")
            {
                nodeSelected.Nodes.Clear();

                SQLiteConnection con = new SQLiteConnection();

                SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
                using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
                {
                    connection.ConnectionString = "Data Source = " + baseName;
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = @"select * from folders where p_id=@p_id;";
                        command.Parameters.Add(new SQLiteParameter("@p_id", nodeSelected.Tag));
                        command.CommandType = CommandType.Text;
                        SQLiteDataReader DataReader = command.ExecuteReader();
                        while (DataReader.Read())
                        {
                            nodeChild = nodeSelected.Nodes.Add(DataReader["name"].ToString());
                            nodeChild.Tag = DataReader["id"];
                            nodeChild.ImageIndex = 0;
                            nodeChild.Nodes.Add("*");
                        }
                    }
                     
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = @"select * from files where p_id=@p_id;";
                        command.Parameters.Add(new SQLiteParameter("@p_id", nodeSelected.Tag));
                        command.CommandType = CommandType.Text;
                        SQLiteDataReader DataReader = command.ExecuteReader();
                        while (DataReader.Read())
                        {
                            nodeChild = nodeSelected.Nodes.Add(DataReader["name"].ToString());
                            nodeChild.Tag = DataReader["id"];
                            nodeChild.ImageIndex = 1;
                        }
                    }
                }

            } 
      }

        private void triStateTreeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            TreeNode nodeSelected, nodeChild;
            nodeSelected = e.Node;


            if (nodeSelected.Nodes[0].Text == "*")
            {
                nodeSelected.Nodes.Clear();

                SQLiteConnection con = new SQLiteConnection();

                SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
                using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
                {
                    connection.ConnectionString = "Data Source = " + baseName;
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = @"select * from folders where p_id=@p_id;";
                        command.Parameters.Add(new SQLiteParameter("@p_id", nodeSelected.Tag));
                        command.CommandType = CommandType.Text;
                        SQLiteDataReader DataReader = command.ExecuteReader();
                        while (DataReader.Read())
                        {
                            nodeChild = triStateTreeView1.AddTreeNode(nodeSelected.Nodes, DataReader["name"].ToString(), 1, CheckBoxState.Checked);
                            nodeChild.Tag = DataReader["id"];
                            triStateTreeView1.AddTreeNode(nodeChild.Nodes, "*", 1, CheckBoxState.Checked);
                        }
                    }

                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = @"select * from files where p_id=@p_id;";
                        command.Parameters.Add(new SQLiteParameter("@p_id", nodeSelected.Tag));
                        command.CommandType = CommandType.Text;
                        SQLiteDataReader DataReader = command.ExecuteReader();
                        while (DataReader.Read())
                        {
                            nodeChild = triStateTreeView1.AddTreeNode(nodeSelected.Nodes, DataReader["name"].ToString(), 2, CheckBoxState.Checked);
                            nodeChild.Tag = DataReader["id"];
                        }
                    }

                    triStateTreeView1.Invalidate();
                    
                }

            } 

        }

        private void treeViewAdv1_Expanding(object sender, Aga.Controls.Tree.TreeViewAdvEventArgs e)
        {

        } 
      }
}
