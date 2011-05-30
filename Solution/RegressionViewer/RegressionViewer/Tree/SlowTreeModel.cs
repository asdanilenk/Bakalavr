using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SQLite;
using Aga.Controls.Tree;
using Aga.Controls.Tree.NodeControls;
using Aga.Controls;


namespace RegressionViewer
{
    public class SlowTreeModel : ITreeModel
    {
        private NodeModule _root;
		public NodeModule Root
		{
			get { return _root; }
		}

		public Collection<Node> Nodes
		{
			get { return _root.Nodes; }
		}

		public TreePath GetPath(NodeModule node)
		{
			if (node == _root)
				return TreePath.Empty;
			else
			{
				Stack<object> stack = new Stack<object>();
				while (node != _root)
				{
					stack.Push(node);
					node = node.Parent as NodeModule;
				}
				return new TreePath(stack.ToArray());
			}
		}

		public NodeModule FindNode(TreePath path)
		{
            if (path.FullPath.Length == 0)
                return null;
			else if (path.FullPath.Length==1)
				return _root;
			else
				return FindNode(_root, path, 1);
		}

		private NodeModule FindNode(NodeModule root, TreePath path, int level)
		{
			foreach (NodeModule node in root.Nodes)
				if (node == path.FullPath[level])
				{
					if (level == path.FullPath.Length - 1)
						return node;
					else
						return FindNode(node, path, level + 1);
				}
			return null;
		}

        #region ITreeModel Members

        public System.Collections.IEnumerable GetChildren(TreePath treePath)
        {
            NodeModule nodeSelected;
            NodeModule nodeChild;
            
            nodeSelected = this.FindNode(treePath);

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"select * from folders where p_id=@p_id;";
                command.Parameters.Add(new SQLiteParameter("@p_id", (nodeSelected != null ? nodeSelected.Tag : "null")));
                SQLiteDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    nodeChild = new NodeModule(DataReader["name"].ToString());
                    nodeChild.Tag = DataReader["id"];
                    
                    if (nodeSelected == null)
                    {
                        _root = nodeChild;
                        _root.Model = this;
                    }
                    else nodeSelected.Nodes.Add(nodeChild);
                    yield return nodeChild;
                }
            }

            using (SQLiteCommand command = new SQLiteCommand(ConnectionManager.connection))
            {
                command.CommandText = @"select name,id,(select name from modules where id=module_id) as module from files where p_id=@p_id;";
                command.Parameters.Add(new SQLiteParameter("@p_id", (nodeSelected != null ? nodeSelected.Tag : "null")));
                SQLiteDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    nodeChild = new NodeModule(DataReader["name"].ToString(),DataReader["module"].ToString());
                    nodeChild.Tag = "f" + DataReader["id"];
                    
                    nodeSelected.Nodes.Add(nodeChild);
                    yield return nodeChild;
                }
            }

        }
        
        public bool IsLeaf(TreePath treePath)
        {
            return (treePath.LastNode as NodeModule).Tag.ToString().StartsWith("f");
        }

        #pragma warning disable 67
        public event EventHandler<TreeModelEventArgs> NodesChanged;
        public event EventHandler<TreeModelEventArgs> NodesInserted;
        public event EventHandler<TreeModelEventArgs> NodesRemoved;
        public event EventHandler<TreePathEventArgs> StructureChanged;
        #pragma warning restore 67

        #endregion
    }


}

