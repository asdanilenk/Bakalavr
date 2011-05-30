using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;

namespace RegressionViewer.Forms
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
            ModulesGraph();
        }

        public GraphForm(int patchid)
        {
            InitializeComponent();
            PatchGraph(patchid);
        }

        private void PatchGraph(int id)
        {
            Graph g = new Graph();

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"select name from modules";

                SQLiteDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                    g.AddNode(DataReader["name"].ToString());
            }

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"select * from patchview where patch_id=@patch_id";
                command.Parameters.Add(new SQLiteParameter("@patch_id", id));
                SQLiteDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    Microsoft.Msagl.Drawing.Edge e = g.AddEdge(DataReader["used"].ToString(), "", DataReader["uses"].ToString());
                    e.Attr.LineWidth = int.Parse(DataReader["count"].ToString());
                    e.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    e.LabelText = DataReader["rate"].ToString();
                }
            }
            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"select * from patchview2 where patch_id=@patch_id";
                command.Parameters.Add(new SQLiteParameter("@patch_id", id));
                SQLiteDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    Microsoft.Msagl.Drawing.Edge e = g.AddEdge(DataReader["used"].ToString(), "", DataReader["uses"].ToString());
                    e.Attr.LineWidth = int.Parse(DataReader["count"].ToString());
                    e.Attr.Color = Microsoft.Msagl.Drawing.Color.Yellow;
                    e.LabelText = (int.Parse(DataReader["rate"].ToString())/10).ToString();
                }
            }
            gViewer.Graph = g;
        }

        private void ModulesGraph()
        {
            Graph g = new Graph();

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"select name from modules";

                SQLiteDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                    g.AddNode(DataReader["name"].ToString());
            }

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"select * from moddeps";
                SQLiteDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    Microsoft.Msagl.Drawing.Edge e = g.AddEdge(DataReader["used"].ToString(), "", DataReader["uses"].ToString());
                    e.Attr.LineWidth = int.Parse(DataReader["count"].ToString());
                    //e.Attr.Color = Microsoft.Msagl.Drawing.Color.Yellow;
                    e.LabelText = DataReader["rate"].ToString();
                }
            }
            gViewer.Graph = g;
            
        }
    }
}
