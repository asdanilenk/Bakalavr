using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using Aga.Controls.Tree;
using Aga.Controls.Tree.NodeControls;
using Aga.Controls;

namespace RegressionViewer
{
    public class NodeModule : Node
    {
        public NodeModule(string text) : base(text) { }
        public NodeModule(string text, string module) : base(text)
        {
            if (module!=null) _module = module;
        }
        private SlowTreeModel _model;
        public new SlowTreeModel Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public new bool IsLeaf
        {
            get
            {
                if (this.Tag != null)
                    return this.Tag.ToString().StartsWith("f");
                else return false;
            }
        }
       
        private string _module;
        public string Module
        {
            get
            {
                return _module;
            }
            set
            {
                if (value != _module)
                {
                    if (this.IsLeaf) _module = value;
                    if (value!=null)
                    {
                        UpdateModulesInTreeRec(this, value);
                        UpdateModulesInDBRec(value, this.Tag.ToString());
                    }
                }
            }
        }

        //Fired when folder in tree is updated to update its childs
        private void UpdateModulesInTreeRec(Node N, string value)
        {
            foreach (NodeModule n in N.Nodes)
            {
                if (n.IsLeaf) n._module = value;
                UpdateModulesInTreeRec(n,value);
            }
        }

        //Fired to update changes made in GUI in database
        public void UpdateModulesInDBRec(string moduleName, string id)
        {
            if (id.StartsWith("f"))
            {
                using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                {
                    command.CommandText = @"Update [files] set module_id=(select id from modules where name=@module) where id=@id";
                    command.Parameters.Add(new SQLiteParameter("@id", id.Substring(1)));
                    command.Parameters.Add(new SQLiteParameter("@module", moduleName));
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                {
                    command.CommandText = @"Select id from folders where p_id=@p_id";
                    command.Parameters.Add(new SQLiteParameter("@p_id", id));
                    SQLiteDataReader DataReader = command.ExecuteReader();
                    while (DataReader.Read())
                        UpdateModulesInDBRec(moduleName, DataReader["id"].ToString());
                }
                using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                {
                    command.CommandText = @"Update [files] set module_id=(select id from modules where name=@module) where p_id=@p_id";
                    command.Parameters.Add(new SQLiteParameter("@p_id", id));
                    command.Parameters.Add(new SQLiteParameter("@module", moduleName));
                    command.ExecuteNonQuery();
                }
            
            }

        }

        //Fired when modules where changed in database (eg deleted, renamed)
        public void UpdateModulesFromDbRec()
        {
            foreach (NodeModule n in this.Nodes)
            {
                if (!n.IsLeaf)
                {
                    using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
                    {
                        command.CommandText = @"select name,id,(select name from modules where id=module_id) as module from files where p_id=@p_id;";
                        command.Parameters.Add(new SQLiteParameter("@p_id", n.Tag));
                        SQLiteDataReader DataReader = command.ExecuteReader();
                        while (DataReader.Read())
                        {
                            try
                            {
                                NodeModule nm = n.Nodes.First(a => a.Tag.ToString() == "f" + DataReader["id"]) as NodeModule;
                                nm.Module = DataReader["module"].ToString();
                            }
                            catch { }
                        }
                    }
                    n.UpdateModulesFromDbRec();
                }
            }
        }
    }
}
