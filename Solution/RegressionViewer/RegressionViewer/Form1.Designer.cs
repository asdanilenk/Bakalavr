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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.triStateTreeView1 = new TriStateTreeView.TriStateTreeView.TriStateTreeView();
            this.treeViewAdv1 = new Aga.Controls.Tree.TreeViewAdv();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(322, 301);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            // 
            // triStateTreeView1
            // 
            this.triStateTreeView1.Location = new System.Drawing.Point(344, 13);
            this.triStateTreeView1.Name = "triStateTreeView1";
            this.triStateTreeView1.Size = new System.Drawing.Size(226, 289);
            this.triStateTreeView1.TabIndex = 1;
            this.triStateTreeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.triStateTreeView1_AfterExpand);
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewAdv1.DefaultToolTipProvider = null;
            this.treeViewAdv1.DragDropMarkColor = System.Drawing.Color.Black;
            this.treeViewAdv1.LineColor = System.Drawing.SystemColors.ControlDark;
            this.treeViewAdv1.Location = new System.Drawing.Point(577, 13);
            this.treeViewAdv1.Model = null;
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.SelectedNode = null;
            this.treeViewAdv1.Size = new System.Drawing.Size(182, 301);
            this.treeViewAdv1.TabIndex = 2;
            this.treeViewAdv1.Text = "treeViewAdv1";
            this.treeViewAdv1.Expanding += new System.EventHandler<Aga.Controls.Tree.TreeViewAdvEventArgs>(this.treeViewAdv1_Expanding);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 326);
            this.Controls.Add(this.treeViewAdv1);
            this.Controls.Add(this.triStateTreeView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private TriStateTreeView.TriStateTreeView.TriStateTreeView triStateTreeView1;
        private Aga.Controls.Tree.TreeViewAdv treeViewAdv1;
    }
}

