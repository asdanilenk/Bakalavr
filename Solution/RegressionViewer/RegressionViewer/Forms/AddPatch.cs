using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SQLite;



namespace RegressionViewer.Forms
{
    public partial class AddPatch : Form
    {
        public AddPatch()
        {
            InitializeComponent();
        }

        private void OtherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OtherRadioButton.Checked == true)
                regexTextBox.Enabled = true;
            else
                regexTextBox.Enabled = false;
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            string pattern;
            if (GITRadioButton.Checked == true)
                pattern = @"M\s*(.+)";
            else if (SVNRadioButton.Checked == true)
                pattern = @"\s\s\sM\s(.+)";
            else pattern = regexTextBox.Text;
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Multiselect = false;
            ofp.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofp.FilterIndex = 2;
            ofp.RestoreDirectory = true;

            if (ofp.ShowDialog() == DialogResult.OK)
            {
                FileInfo input = new FileInfo(ofp.FileName);
                if (input.Exists)
                {
                    StreamReader SR;
                    try { SR = input.OpenText(); }
                    catch { MessageBox.Show("Cannot open File for reading"); return; };
                    string s;
                    changesDataGridView.Rows.Clear();
                    while (!SR.EndOfStream)
                    {
                        s = SR.ReadLine();
                        foreach (Match match in Regex.Matches(s, pattern, RegexOptions.IgnoreCase))
                        {
                            changesDataGridView.Rows.Add();
                            bool found = FindFile(match.Groups[1].Value)!=0;
                            changesDataGridView.Rows[changesDataGridView.Rows.Count - 1].Cells[0].Value = match.Groups[1].Value;
                            if (!found)
                                changesDataGridView.Rows[changesDataGridView.Rows.Count - 1].Cells[0].Style.ForeColor = Color.Purple;
                        }
                    }
                    patchNameTextBox.Text = Path.GetFileNameWithoutExtension(ofp.FileName);
                    patchFileTextBox.Text = input.Name; 
                    OKButton.Enabled = true;
                }
                else MessageBox.Show("File doesn't exist");
            }
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string patchname = patchNameTextBox.Text;
            int patch_id;
            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"insert into patches (name) values (@name); SELECT last_insert_rowid() AS [ID]";
                command.Parameters.Add(new SQLiteParameter("@name", patchname));
                patch_id = int.Parse(command.ExecuteScalar().ToString());
            }

            foreach (DataGridViewRow dgvr in changesDataGridView.Rows)
            {
                string file = dgvr.Cells[0].Value.ToString();
                int file_id = FindFile(file);
                if (file_id!=0)
                    using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                    {
                        command.CommandText = @"insert into patchdetails (patch_id,file_id) values (@patch_id,@file_id)";
                        command.Parameters.Add(new SQLiteParameter("@patch_id", patch_id));
                        command.Parameters.Add(new SQLiteParameter("@file_id", file_id));
                        command.ExecuteNonQuery();
                    }
            }
            this.Close();
        }
        private int FindFile(string file)
        {
            if (file.StartsWith("/") || file.StartsWith("\\")) file = file.Substring(1);
            string[] parts = file.Split(new char[2] { '/', '\\' });
            int id=0;
            int index = 0;
            if (parts.Length > 1)
            {
                using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                {
                    command.CommandText = @"select id from folders where name=@name and p_id='null'";
                    command.Parameters.Add(new SQLiteParameter("@name", parts[index]));
                    id = Convert.ToInt32(command.ExecuteScalar());
                    if (id == 0)
                    {
                        if (parts.Length > 2)
                        {
                            index++;
                            command.Parameters.Add(new SQLiteParameter("@name", parts[index]));
                            id = Convert.ToInt32(command.ExecuteScalar());
                        }
                    }
                }
            }
            if (id == 0)
            {
                using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                {
                    command.CommandText = @"select id from folders where name=@name and p_id=(select id from folders where p_id='null')";
                    command.Parameters.Add(new SQLiteParameter("@name", parts[index]));
                    id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            if (id == 0)
            {
                if (index == parts.Length - 1)
                {
                    using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                    {
                        command.CommandText = @"select id from files where name=@name and p_id=(select id from folders where p_id='null')";
                        command.Parameters.Add(new SQLiteParameter("@name", parts[index]));
                        id = Convert.ToInt32(command.ExecuteScalar());
                        if (id != 0) return id;
                    }
                }
                else return 0;
            }
            //Parent folder found
            for (; index < parts.Length - 2; )
            {
                index++;
                using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                {
                    command.CommandText = @"select id from folders where name=@name and p_id=@id";
                    command.Parameters.Add(new SQLiteParameter("@name", parts[index]));
                    command.Parameters.Add(new SQLiteParameter("@id", id));
                    id = Convert.ToInt32(command.ExecuteScalar());
                    if (id == 0) return 0;
                }
            }
            index++;
            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"select id from files where name=@name and p_id=@id";
                command.Parameters.Add(new SQLiteParameter("@name", parts[index]));
                command.Parameters.Add(new SQLiteParameter("@id", id));
                id = Convert.ToInt32(command.ExecuteScalar());
            }
            return id;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
