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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeView = new Aga.Controls.Tree.TreeViewAdv();
            this.pathColumn = new Aga.Controls.Tree.TreeColumn();
            this.modulesColumn = new Aga.Controls.Tree.TreeColumn();
            this.treeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteTreeContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeNodeIcon = new Aga.Controls.Tree.NodeControls.NodeStateIcon();
            this.treeNodeName = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.treeNodeModule = new Aga.Controls.Tree.NodeControls.NodeComboBox();
            this.modulesView = new System.Windows.Forms.DataGridView();
            this.nameModulesViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteModulesContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programDataSet = new RegressionViewer.ModulesDataSet();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.modulesTableAdapter = new RegressionViewer.ProgramDataSetTableAdapters.modulesTableAdapter();
            this.treeContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulesView)).BeginInit();
            this.modulesContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.AutoRowHeight = true;
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.treeView.Columns.Add(this.pathColumn);
            this.treeView.Columns.Add(this.modulesColumn);
            this.treeView.ContextMenuStrip = this.treeContextMenu;
            this.treeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView.DefaultToolTipProvider = null;
            this.treeView.DragDropMarkColor = System.Drawing.Color.Black;
            this.treeView.LineColor = System.Drawing.SystemColors.ControlDark;
            this.treeView.LoadOnDemand = true;
            this.treeView.Location = new System.Drawing.Point(12, 13);
            this.treeView.Model = null;
            this.treeView.Name = "treeView";
            this.treeView.NodeControls.Add(this.treeNodeIcon);
            this.treeView.NodeControls.Add(this.treeNodeName);
            this.treeView.NodeControls.Add(this.treeNodeModule);
            this.treeView.SelectedNode = null;
            this.treeView.SelectionMode = Aga.Controls.Tree.TreeSelectionMode.Multi;
            this.treeView.Size = new System.Drawing.Size(514, 301);
            this.treeView.TabIndex = 2;
            this.treeView.Text = "treeViewAdv1";
            this.treeView.UseColumns = true;
            this.treeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewAdv1_KeyDown);
            // 
            // pathColumn
            // 
            this.pathColumn.Header = "Path";
            this.pathColumn.SortOrder = System.Windows.Forms.SortOrder.None;
            this.pathColumn.TooltipText = null;
            this.pathColumn.Width = 420;
            // 
            // modulesColumn
            // 
            this.modulesColumn.Header = "Module";
            this.modulesColumn.SortOrder = System.Windows.Forms.SortOrder.None;
            this.modulesColumn.TooltipText = null;
            this.modulesColumn.Width = 80;
            // 
            // treeContextMenu
            // 
            this.treeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTreeContextMenuItem});
            this.treeContextMenu.Name = "contextMenuStrip1";
            this.treeContextMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteTreeContextMenuItem
            // 
            this.deleteTreeContextMenuItem.Name = "deleteTreeContextMenuItem";
            this.deleteTreeContextMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteTreeContextMenuItem.Text = "Delete";
            this.deleteTreeContextMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // treeNodeIcon
            // 
            this.treeNodeIcon.LeftMargin = 1;
            this.treeNodeIcon.ParentColumn = this.pathColumn;
            this.treeNodeIcon.ScaleMode = Aga.Controls.Tree.ImageScaleMode.Clip;
            // 
            // treeNodeName
            // 
            this.treeNodeName.DataPropertyName = "Text";
            this.treeNodeName.EditEnabled = true;
            this.treeNodeName.IncrementalSearchEnabled = true;
            this.treeNodeName.LeftMargin = 3;
            this.treeNodeName.ParentColumn = this.pathColumn;
            // 
            // treeNodeModule
            // 
            this.treeNodeModule.DataPropertyName = "Module";
            this.treeNodeModule.EditEnabled = true;
            this.treeNodeModule.EditOnClick = true;
            this.treeNodeModule.IncrementalSearchEnabled = true;
            this.treeNodeModule.LeftMargin = 3;
            this.treeNodeModule.ParentColumn = this.modulesColumn;
            this.treeNodeModule.ChangesApplied += new System.EventHandler(this._nodeModule_ChangesApplied);
            // 
            // modulesView
            // 
            this.modulesView.AllowUserToResizeColumns = false;
            this.modulesView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.NullValue = "<Click to add module>";
            this.modulesView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.modulesView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modulesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.modulesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modulesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameModulesViewColumn});
            this.modulesView.ContextMenuStrip = this.modulesContextMenu;
            this.modulesView.DataSource = this.modulesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "<Click to add module>";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.modulesView.DefaultCellStyle = dataGridViewCellStyle3;
            this.modulesView.Location = new System.Drawing.Point(542, 13);
            this.modulesView.Name = "modulesView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modulesView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.modulesView.RowHeadersWidth = 15;
            this.modulesView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modulesView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.modulesView.Size = new System.Drawing.Size(217, 150);
            this.modulesView.TabIndex = 3;
            // 
            // nameModulesViewColumn
            // 
            this.nameModulesViewColumn.DataPropertyName = "name";
            this.nameModulesViewColumn.HeaderText = "Modules";
            this.nameModulesViewColumn.Name = "nameModulesViewColumn";
            this.nameModulesViewColumn.Width = 200;
            // 
            // modulesContextMenu
            // 
            this.modulesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteModulesContextMenuItem});
            this.modulesContextMenu.Name = "modulesContextMenu";
            this.modulesContextMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteModulesContextMenuItem
            // 
            this.deleteModulesContextMenuItem.Name = "deleteModulesContextMenuItem";
            this.deleteModulesContextMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteModulesContextMenuItem.Text = "Delete";
            this.deleteModulesContextMenuItem.Click += new System.EventHandler(this.deleteModulesContextMenuItem_Click);
            // 
            // modulesBindingSource
            // 
            this.modulesBindingSource.DataMember = "modules";
            this.modulesBindingSource.DataSource = this.programDataSet;
            // 
            // programDataSet
            // 
            this.programDataSet.DataSetName = "ProgramDataSet";
            this.programDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(553, 179);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(86, 23);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Apply changes";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(661, 178);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // modulesTableAdapter
            // 
            this.modulesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 326);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.modulesView);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TreeView_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.treeContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modulesView)).EndInit();
            this.modulesContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Aga.Controls.Tree.TreeViewAdv treeView;
        private Aga.Controls.Tree.NodeControls.NodeStateIcon treeNodeIcon;
        private Aga.Controls.Tree.NodeControls.NodeTextBox treeNodeName;
        private Aga.Controls.Tree.TreeColumn pathColumn;
        private Aga.Controls.Tree.TreeColumn modulesColumn;
        private Aga.Controls.Tree.NodeControls.NodeComboBox treeNodeModule;
        private System.Windows.Forms.DataGridView modulesView;
        private ModulesDataSet programDataSet;
        private System.Windows.Forms.BindingSource modulesBindingSource;
        private ProgramDataSetTableAdapters.modulesTableAdapter modulesTableAdapter;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameModulesViewColumn;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ContextMenuStrip treeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteTreeContextMenuItem;
        private System.Windows.Forms.ContextMenuStrip modulesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteModulesContextMenuItem;
		
    }
}

