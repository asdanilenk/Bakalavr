namespace RegressionViewer
{
    partial class RelationshipsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.relsDataSet = new RegressionViewer.RelsDataSet();
            this.relsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relsTableAdapter = new RegressionViewer.RelsDataSetTableAdapters.relsTableAdapter();
            this.usesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usesmoduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usedmoduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usesDataGridViewTextBoxColumn,
            this.usesmoduleDataGridViewTextBoxColumn,
            this.usedDataGridViewTextBoxColumn,
            this.usedmoduleDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.relsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(549, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // relsDataSet
            // 
            this.relsDataSet.DataSetName = "RelsDataSet";
            this.relsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relsBindingSource
            // 
            this.relsBindingSource.DataMember = "rels";
            this.relsBindingSource.DataSource = this.relsDataSet;
            // 
            // relsTableAdapter
            // 
            this.relsTableAdapter.ClearBeforeFill = true;
            // 
            // usesDataGridViewTextBoxColumn
            // 
            this.usesDataGridViewTextBoxColumn.DataPropertyName = "[uses]";
            this.usesDataGridViewTextBoxColumn.HeaderText = "[uses]";
            this.usesDataGridViewTextBoxColumn.Name = "usesDataGridViewTextBoxColumn";
            this.usesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usesmoduleDataGridViewTextBoxColumn
            // 
            this.usesmoduleDataGridViewTextBoxColumn.DataPropertyName = "[uses_module]";
            this.usesmoduleDataGridViewTextBoxColumn.HeaderText = "[uses_module]";
            this.usesmoduleDataGridViewTextBoxColumn.Name = "usesmoduleDataGridViewTextBoxColumn";
            this.usesmoduleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usedDataGridViewTextBoxColumn
            // 
            this.usedDataGridViewTextBoxColumn.DataPropertyName = "[used]";
            this.usedDataGridViewTextBoxColumn.HeaderText = "[used]";
            this.usedDataGridViewTextBoxColumn.Name = "usedDataGridViewTextBoxColumn";
            this.usedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usedmoduleDataGridViewTextBoxColumn
            // 
            this.usedmoduleDataGridViewTextBoxColumn.DataPropertyName = "[used_module]";
            this.usedmoduleDataGridViewTextBoxColumn.HeaderText = "[used_module]";
            this.usedmoduleDataGridViewTextBoxColumn.Name = "usedmoduleDataGridViewTextBoxColumn";
            this.usedmoduleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "[rate]";
            this.rateDataGridViewTextBoxColumn.HeaderText = "[rate]";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RelationshipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RelationshipsForm";
            this.Text = "RelationshipsForm";
            this.Load += new System.EventHandler(this.RelationshipsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RelsDataSet relsDataSet;
        private System.Windows.Forms.BindingSource relsBindingSource;
        private RelsDataSetTableAdapters.relsTableAdapter relsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usesmoduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usedmoduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        
        
    }
}