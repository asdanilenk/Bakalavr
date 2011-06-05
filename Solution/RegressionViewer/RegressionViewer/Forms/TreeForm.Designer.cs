using RegressionViewer.DataSets;
using RegressionViewer.DataSets.FilesDataSetTableAdapters;
using RegressionViewer.DataSets.ModulesDataSetTableAdapters;
using RegressionViewer.DataSets.PatchesDataSetTableAdapters;
namespace RegressionViewer.Forms
{
    partial class TreeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.modulesDataSet = new ModulesDataSet();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.modulesTableAdapter = new modulesTableAdapter();
            this.patchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patchesDataSet = new PatchesDataSet();
            this.patchesDelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patchesTableAdapter = new patchesTableAdapter();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesRelationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchesStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.deletePatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePatchToolStripMenuCombo = new System.Windows.Forms.ToolStripComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.treeContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulesView)).BeginInit();
            this.modulesContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchesDelBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
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
            this.treeView.Enabled = false;
            this.treeView.LineColor = System.Drawing.SystemColors.ControlDark;
            this.treeView.LoadOnDemand = true;
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Model = null;
            this.treeView.Name = "treeView";
            this.treeView.NodeControls.Add(this.treeNodeIcon);
            this.treeView.NodeControls.Add(this.treeNodeName);
            this.treeView.NodeControls.Add(this.treeNodeModule);
            this.treeView.SelectedNode = null;
            this.treeView.SelectionMode = Aga.Controls.Tree.TreeSelectionMode.Multi;
            this.treeView.Size = new System.Drawing.Size(521, 369);
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
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.NullValue = "<Click to add module>";
            this.modulesView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.modulesView.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modulesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.modulesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modulesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameModulesViewColumn});
            this.modulesView.ContextMenuStrip = this.modulesContextMenu;
            this.modulesView.DataSource = this.modulesBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.NullValue = "<Click to add module>";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.modulesView.DefaultCellStyle = dataGridViewCellStyle8;
            this.modulesView.Enabled = false;
            this.modulesView.Location = new System.Drawing.Point(530, 3);
            this.modulesView.Name = "modulesView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modulesView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.modulesView.RowHeadersWidth = 21;
            this.modulesView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modulesView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.modulesView.Size = new System.Drawing.Size(217, 151);
            this.modulesView.TabIndex = 3;
            // 
            // nameModulesViewColumn
            // 
            this.nameModulesViewColumn.DataPropertyName = "name";
            this.nameModulesViewColumn.HeaderText = "Modules";
            this.nameModulesViewColumn.Name = "nameModulesViewColumn";
            this.nameModulesViewColumn.Width = 170;
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
            this.modulesBindingSource.DataSource = this.modulesDataSet;
            // 
            // modulesDataSet
            // 
            this.modulesDataSet.DataSetName = "ModulesDataSet";
            this.modulesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(530, 166);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(97, 24);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Apply changes";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(650, 166);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 24);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // modulesTableAdapter
            // 
            this.modulesTableAdapter.ClearBeforeFill = true;
            // 
            // patchesBindingSource
            // 
            this.patchesBindingSource.DataMember = "patches";
            this.patchesBindingSource.DataSource = this.patchesDataSet;
            // 
            // patchesDataSet
            // 
            this.patchesDataSet.DataSetName = "PatchesDataSet";
            this.patchesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patchesDelBindingSource
            // 
            this.patchesDelBindingSource.DataMember = "patches";
            this.patchesDelBindingSource.DataSource = this.patchesDataSet;
            // 
            // patchesTableAdapter
            // 
            this.patchesTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.relationsToolStripMenuItem,
            this.patchesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(794, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.separatorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newToolStripMenuItem.Text = "New project";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openProjectToolStripMenuItem.Text = "Open project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.closeProjectToolStripMenuItem.Text = "Close project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // separatorToolStripMenuItem
            // 
            this.separatorToolStripMenuItem.Name = "separatorToolStripMenuItem";
            this.separatorToolStripMenuItem.Size = new System.Drawing.Size(140, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // relationsToolStripMenuItem
            // 
            this.relationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesRelationsToolStripMenuItem,
            this.modulesGraphToolStripMenuItem});
            this.relationsToolStripMenuItem.Enabled = false;
            this.relationsToolStripMenuItem.Name = "relationsToolStripMenuItem";
            this.relationsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.relationsToolStripMenuItem.Text = "Relations";
            // 
            // filesRelationsToolStripMenuItem
            // 
            this.filesRelationsToolStripMenuItem.Name = "filesRelationsToolStripMenuItem";
            this.filesRelationsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.filesRelationsToolStripMenuItem.Text = "Files Relations";
            this.filesRelationsToolStripMenuItem.Click += new System.EventHandler(this.filesRelationsToolStripMenuItem_Click);
            // 
            // modulesGraphToolStripMenuItem
            // 
            this.modulesGraphToolStripMenuItem.Name = "modulesGraphToolStripMenuItem";
            this.modulesGraphToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.modulesGraphToolStripMenuItem.Text = "Modules Graph";
            this.modulesGraphToolStripMenuItem.Click += new System.EventHandler(this.modulesGraphToolStripMenuItem_Click);
            // 
            // patchesToolStripMenuItem
            // 
            this.patchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatchToolStripMenuItem,
            this.showPatchToolStripMenuItem,
            this.deletePatchToolStripMenuItem});
            this.patchesToolStripMenuItem.Enabled = false;
            this.patchesToolStripMenuItem.Name = "patchesToolStripMenuItem";
            this.patchesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.patchesToolStripMenuItem.Text = "Patches";
            // 
            // addPatchToolStripMenuItem
            // 
            this.addPatchToolStripMenuItem.Name = "addPatchToolStripMenuItem";
            this.addPatchToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addPatchToolStripMenuItem.Text = "Add Patch";
            this.addPatchToolStripMenuItem.Click += new System.EventHandler(this.addPatchToolStripMenuItem_Click);
            // 
            // showPatchToolStripMenuItem
            // 
            this.showPatchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patchesStripComboBox});
            this.showPatchToolStripMenuItem.Name = "showPatchToolStripMenuItem";
            this.showPatchToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.showPatchToolStripMenuItem.Text = "Show Patch";
            // 
            // patchesStripComboBox
            // 
            this.patchesStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patchesStripComboBox.Name = "patchesStripComboBox";
            this.patchesStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.patchesStripComboBox.SelectedIndexChanged += new System.EventHandler(this.patchesStripComboBox_Click);
            // 
            // deletePatchToolStripMenuItem
            // 
            this.deletePatchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeletePatchToolStripMenuCombo});
            this.deletePatchToolStripMenuItem.Name = "deletePatchToolStripMenuItem";
            this.deletePatchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deletePatchToolStripMenuItem.Text = "Delete Patch";
            // 
            // DeletePatchToolStripMenuCombo
            // 
            this.DeletePatchToolStripMenuCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeletePatchToolStripMenuCombo.Name = "DeletePatchToolStripMenuCombo";
            this.DeletePatchToolStripMenuCombo.Size = new System.Drawing.Size(152, 23);
            this.DeletePatchToolStripMenuCombo.SelectedIndexChanged += new System.EventHandler(this.DeletePatchToolStripMenuCombo_SelectedIndexChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.treeView);
            this.mainPanel.Controls.Add(this.modulesView);
            this.mainPanel.Controls.Add(this.applyButton);
            this.mainPanel.Controls.Add(this.cancelButton);
            this.mainPanel.Enabled = false;
            this.mainPanel.Location = new System.Drawing.Point(12, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(758, 378);
            this.mainPanel.TabIndex = 12;
            this.mainPanel.EnabledChanged += new System.EventHandler(this.mainPanel_EnabledChanged);
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 412);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.mainPanel);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Regression Viewer";
            this.treeContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modulesView)).EndInit();
            this.modulesContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchesDelBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Aga.Controls.Tree.TreeViewAdv treeView;
        private Aga.Controls.Tree.NodeControls.NodeStateIcon treeNodeIcon;
        private Aga.Controls.Tree.NodeControls.NodeTextBox treeNodeName;
        private Aga.Controls.Tree.TreeColumn pathColumn;
        private Aga.Controls.Tree.TreeColumn modulesColumn;
        private Aga.Controls.Tree.NodeControls.NodeComboBox treeNodeModule;
        private System.Windows.Forms.DataGridView modulesView;
        private ModulesDataSet modulesDataSet;
        private System.Windows.Forms.BindingSource modulesBindingSource;
        private modulesTableAdapter modulesTableAdapter;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ContextMenuStrip treeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteTreeContextMenuItem;
        private System.Windows.Forms.ContextMenuStrip modulesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteModulesContextMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameModulesViewColumn;
        private PatchesDataSet patchesDataSet;
        private System.Windows.Forms.BindingSource patchesBindingSource;
        private System.Windows.Forms.BindingSource patchesDelBindingSource;
        private patchesTableAdapter patchesTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesRelationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulesGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox patchesStripComboBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem deletePatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox DeletePatchToolStripMenuCombo;
		
    }
}
