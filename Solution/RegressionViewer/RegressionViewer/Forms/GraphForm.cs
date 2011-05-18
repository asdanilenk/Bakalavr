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
                    /*if (values[j, i] > 0)
                            e.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        else
                            e.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    */
                }
            }
            gViewer.Graph = g;
            
        }
    }
}
