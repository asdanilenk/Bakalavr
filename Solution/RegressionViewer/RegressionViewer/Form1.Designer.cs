namespace RegressionViewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewAdv1 = new Aga.Controls.Tree.TreeViewAdv();
            this.treeColumn1 = new Aga.Controls.Tree.TreeColumn();
            this.treeColumn2 = new Aga.Controls.Tree.TreeColumn();
            this._nodeCheckBox = new Aga.Controls.Tree.NodeControls.NodeCheckBox();
            this._nodeStateIcon = new Aga.Controls.Tree.NodeControls.NodeStateIcon();
            this._nodeName = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this._nodeModule = new Aga.Controls.Tree.NodeControls.NodeComboBox();
            this.SuspendLayout();
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewAdv1.AutoRowHeight = true;
            this.treeViewAdv1.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewAdv1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.treeViewAdv1.Columns.Add(this.treeColumn1);
            this.treeViewAdv1.Columns.Add(this.treeColumn2);
            this.treeViewAdv1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeViewAdv1.DefaultToolTipProvider = null;
            this.treeViewAdv1.DragDropMarkColor = System.Drawing.Color.Black;
            this.treeViewAdv1.LineColor = System.Drawing.SystemColors.ControlDark;
            this.treeViewAdv1.LoadOnDemand = true;
            this.treeViewAdv1.Location = new System.Drawing.Point(12, 13);
            this.treeViewAdv1.Model = null;
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.NodeControls.Add(this._nodeCheckBox);
            this.treeViewAdv1.NodeControls.Add(this._nodeStateIcon);
            this.treeViewAdv1.NodeControls.Add(this._nodeName);
            this.treeViewAdv1.NodeControls.Add(this._nodeModule);
            this.treeViewAdv1.SelectedNode = null;
            this.treeViewAdv1.SelectionMode = Aga.Controls.Tree.TreeSelectionMode.Multi;
            this.treeViewAdv1.Size = new System.Drawing.Size(305, 301);
            this.treeViewAdv1.TabIndex = 2;
            this.treeViewAdv1.Text = "treeViewAdv1";
            this.treeViewAdv1.UseColumns = true;
            // 
            // treeColumn1
            // 
            this.treeColumn1.Header = "Path";
            this.treeColumn1.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeColumn1.TooltipText = null;
            this.treeColumn1.Width = 220;
            // 
            // treeColumn2
            // 
            this.treeColumn2.Header = "Module";
            this.treeColumn2.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeColumn2.TooltipText = null;
            this.treeColumn2.Width = 80;
            // 
            // _nodeCheckBox
            // 
            this._nodeCheckBox.DataPropertyName = "CheckState";
            this._nodeCheckBox.EditEnabled = true;
            this._nodeCheckBox.IncrementalSearchEnabled = true;
            this._nodeCheckBox.LeftMargin = 0;
            this._nodeCheckBox.ParentColumn = this.treeColumn1;
            // 
            // _nodeStateIcon
            // 
            this._nodeStateIcon.LeftMargin = 1;
            this._nodeStateIcon.ParentColumn = this.treeColumn1;
            this._nodeStateIcon.ScaleMode = Aga.Controls.Tree.ImageScaleMode.Clip;
            // 
            // _nodeName
            // 
            this._nodeName.DataPropertyName = "Text";
            this._nodeName.EditEnabled = true;
            this._nodeName.IncrementalSearchEnabled = true;
            this._nodeName.LeftMargin = 3;
            this._nodeName.ParentColumn = this.treeColumn1;
            // 
            // _nodeModule
            // 
            this._nodeModule.DataPropertyName = "Module";
            this._nodeModule.DropDownItems.Add("2");
            this._nodeModule.DropDownItems.Add("3");
            this._nodeModule.DropDownItems.Add("4");
            this._nodeModule.EditEnabled = true;
            this._nodeModule.EditOnClick = true;
            this._nodeModule.IncrementalSearchEnabled = true;
            this._nodeModule.LeftMargin = 3;
            this._nodeModule.ParentColumn = this.treeColumn2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 326);
            this.Controls.Add(this.treeViewAdv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Aga.Controls.Tree.TreeViewAdv treeViewAdv1;
        private Aga.Controls.Tree.NodeControls.NodeCheckBox _nodeCheckBox;
        private Aga.Controls.Tree.NodeControls.NodeStateIcon _nodeStateIcon;
        private Aga.Controls.Tree.NodeControls.NodeTextBox _nodeName;
        private Aga.Controls.Tree.TreeColumn treeColumn1;
        private Aga.Controls.Tree.TreeColumn treeColumn2;
        private Aga.Controls.Tree.NodeControls.NodeComboBox _nodeModule;
		
    }
}

