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
            this._nodeCheckBox = new Aga.Controls.Tree.NodeControls.NodeCheckBox();
            this._nodeStateIcon = new Aga.Controls.Tree.NodeControls.NodeStateIcon();
            this._nodeTextBox = new Aga.Controls.Tree.NodeControls.NodeTextBox();
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
            this.treeViewAdv1.NodeControls.Add(this._nodeTextBox);
            this.treeViewAdv1.SelectedNode = null;
            this.treeViewAdv1.SelectionMode = Aga.Controls.Tree.TreeSelectionMode.MultiSameParent;
            this.treeViewAdv1.Size = new System.Drawing.Size(309, 301);
            this.treeViewAdv1.TabIndex = 2;
            this.treeViewAdv1.Text = "treeViewAdv1";
            // 
            // _nodeCheckBox
            // 
            this._nodeCheckBox.DataPropertyName = "CheckState";
            this._nodeCheckBox.EditEnabled = true;
            this._nodeCheckBox.IncrementalSearchEnabled = true;
            this._nodeCheckBox.LeftMargin = 0;
            this._nodeCheckBox.ParentColumn = null;
            
            // 
            // _nodeStateIcon
            // 
            this._nodeStateIcon.LeftMargin = 1;
            this._nodeStateIcon.ParentColumn = null;
            this._nodeStateIcon.ScaleMode = Aga.Controls.Tree.ImageScaleMode.Clip;
            // 
            // _nodeTextBox
            // 
            this._nodeTextBox.DataPropertyName = "Text";
            this._nodeTextBox.EditEnabled = true;
            this._nodeTextBox.IncrementalSearchEnabled = true;
            this._nodeTextBox.LeftMargin = 3;
            this._nodeTextBox.ParentColumn = null;
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
        private Aga.Controls.Tree.NodeControls.NodeTextBox _nodeTextBox;
		
    }
}

