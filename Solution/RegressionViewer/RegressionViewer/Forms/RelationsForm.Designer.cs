using RegressionViewer.DataSets;
using RegressionViewer.DataSets.RelsDataSetTableAdapters;
namespace RegressionViewer.Forms
{
    partial class RelationsForm
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
            this.relsGrid = new System.Windows.Forms.DataGridView();
            this.usesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usesmoduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usedmoduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relsDataSet = new RelsDataSet();
            this.relsTableAdapter = new relsTableAdapter();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.relsGrid)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // relsGrid
            // 
            this.relsGrid.AllowUserToAddRows = false;
            this.relsGrid.AutoGenerateColumns = false;
            this.relsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usesDataGridViewTextBoxColumn,
            this.usesmoduleDataGridViewTextBoxColumn,
            this.usedDataGridViewTextBoxColumn,
            this.usedmoduleDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn});
            this.relsGrid.ContextMenuStrip = this.contextMenu;
            this.relsGrid.DataSource = this.relsBindingSource;
            this.relsGrid.Location = new System.Drawing.Point(13, 13);
            this.relsGrid.Name = "relsGrid";
            this.relsGrid.ReadOnly = true;
            this.relsGrid.RowHeadersWidth = 21;
            this.relsGrid.Size = new System.Drawing.Size(525, 237);
            this.relsGrid.TabIndex = 0;
            // 
            // usesDataGridViewTextBoxColumn
            // 
            this.usesDataGridViewTextBoxColumn.DataPropertyName = "uses";
            this.usesDataGridViewTextBoxColumn.HeaderText = "File that uses";
            this.usesDataGridViewTextBoxColumn.Name = "usesDataGridViewTextBoxColumn";
            this.usesDataGridViewTextBoxColumn.ReadOnly = true;
            this.usesDataGridViewTextBoxColumn.Width = 110;
            // 
            // usesmoduleDataGridViewTextBoxColumn
            // 
            this.usesmoduleDataGridViewTextBoxColumn.DataPropertyName = "uses_module";
            this.usesmoduleDataGridViewTextBoxColumn.HeaderText = "Module";
            this.usesmoduleDataGridViewTextBoxColumn.Name = "usesmoduleDataGridViewTextBoxColumn";
            this.usesmoduleDataGridViewTextBoxColumn.ReadOnly = true;
            this.usesmoduleDataGridViewTextBoxColumn.Width = 90;
            // 
            // usedDataGridViewTextBoxColumn
            // 
            this.usedDataGridViewTextBoxColumn.DataPropertyName = "used";
            this.usedDataGridViewTextBoxColumn.HeaderText = "File that is used";
            this.usedDataGridViewTextBoxColumn.Name = "usedDataGridViewTextBoxColumn";
            this.usedDataGridViewTextBoxColumn.ReadOnly = true;
            this.usedDataGridViewTextBoxColumn.Width = 110;
            // 
            // usedmoduleDataGridViewTextBoxColumn
            // 
            this.usedmoduleDataGridViewTextBoxColumn.DataPropertyName = "used_module";
            this.usedmoduleDataGridViewTextBoxColumn.HeaderText = "Module";
            this.usedmoduleDataGridViewTextBoxColumn.Name = "usedmoduleDataGridViewTextBoxColumn";
            this.usedmoduleDataGridViewTextBoxColumn.ReadOnly = true;
            this.usedmoduleDataGridViewTextBoxColumn.Width = 90;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // relsBindingSource
            // 
            this.relsBindingSource.DataMember = "rels";
            this.relsBindingSource.DataSource = this.relsDataSet;
            // 
            // relsDataSet
            // 
            this.relsDataSet.DataSetName = "RelsDataSet";
            this.relsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relsTableAdapter
            // 
            this.relsTableAdapter.ClearBeforeFill = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(544, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(52, 25);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(544, 44);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(52, 25);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // RelationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 258);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.relsGrid);
            this.Controls.Add(this.addButton);
            this.Name = "RelationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relations View";
            this.Load += new System.EventHandler(this.RelationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relsGrid)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.relsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView relsGrid;
        private RelsDataSet relsDataSet;
        private System.Windows.Forms.BindingSource relsBindingSource;
        private relsTableAdapter relsTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn usesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usesmoduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usedmoduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        
        
    }
}