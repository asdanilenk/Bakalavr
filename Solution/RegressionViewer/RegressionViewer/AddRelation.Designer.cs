namespace RegressionViewer
{
    partial class AddRelation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usesModuleCombo = new System.Windows.Forms.ComboBox();
            this.modulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulesDataSet = new RegressionViewer.ModulesDataSet();
            this.usesNameCombo = new System.Windows.Forms.ComboBox();
            this.filesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filesDataSet = new RegressionViewer.FilesDataSet();
            this.usedModuleCombo = new System.Windows.Forms.ComboBox();
            this.usedNameCombo = new System.Windows.Forms.ComboBox();
            this.rankUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.filesTableAdapter = new RegressionViewer.FilesDataSetTableAdapters.filesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File that uses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File that is used";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Module";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // usesModuleCombo
            // 
            this.usesModuleCombo.DataSource = this.modulesBindingSource;
            this.usesModuleCombo.DisplayMember = "name";
            this.usesModuleCombo.FormattingEnabled = true;
            this.usesModuleCombo.Location = new System.Drawing.Point(160, 13);
            this.usesModuleCombo.Name = "usesModuleCombo";
            this.usesModuleCombo.Size = new System.Drawing.Size(121, 21);
            this.usesModuleCombo.TabIndex = 6;
            this.usesModuleCombo.ValueMember = "id";
            // 
            // modulesBindingSource
            // 
            this.modulesBindingSource.DataMember = "modules";
            this.modulesBindingSource.DataSource = this.modulesDataSetBindingSource;
            // 
            // modulesDataSetBindingSource
            // 
            this.modulesDataSetBindingSource.DataSource = this.modulesDataSet;
            this.modulesDataSetBindingSource.Position = 0;
            // 
            // modulesDataSet
            // 
            this.modulesDataSet.DataSetName = "ProgramDataSet";
            this.modulesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usesNameCombo
            // 
            this.usesNameCombo.DataSource = this.filesBindingSource;
            this.usesNameCombo.DisplayMember = "name";
            this.usesNameCombo.FormattingEnabled = true;
            this.usesNameCombo.Location = new System.Drawing.Point(160, 41);
            this.usesNameCombo.Name = "usesNameCombo";
            this.usesNameCombo.Size = new System.Drawing.Size(121, 21);
            this.usesNameCombo.TabIndex = 7;
            this.usesNameCombo.ValueMember = "id";
            // 
            // filesBindingSource
            // 
            this.filesBindingSource.DataMember = "files";
            this.filesBindingSource.DataSource = this.filesDataSet;
            // 
            // filesDataSet
            // 
            this.filesDataSet.DataSetName = "FilesDataSet";
            this.filesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usedModuleCombo
            // 
            this.usedModuleCombo.DataSource = this.modulesBindingSource;
            this.usedModuleCombo.DisplayMember = "name";
            this.usedModuleCombo.FormattingEnabled = true;
            this.usedModuleCombo.Location = new System.Drawing.Point(160, 70);
            this.usedModuleCombo.Name = "usedModuleCombo";
            this.usedModuleCombo.Size = new System.Drawing.Size(121, 21);
            this.usedModuleCombo.TabIndex = 8;
            this.usedModuleCombo.ValueMember = "id";
            // 
            // usedNameCombo
            // 
            this.usedNameCombo.DataSource = this.filesBindingSource;
            this.usedNameCombo.DisplayMember = "name";
            this.usedNameCombo.FormattingEnabled = true;
            this.usedNameCombo.Location = new System.Drawing.Point(160, 97);
            this.usedNameCombo.Name = "usedNameCombo";
            this.usedNameCombo.Size = new System.Drawing.Size(121, 21);
            this.usedNameCombo.TabIndex = 9;
            this.usedNameCombo.ValueMember = "id";
            // 
            // rankUpDown
            // 
            this.rankUpDown.Location = new System.Drawing.Point(160, 125);
            this.rankUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rankUpDown.Name = "rankUpDown";
            this.rankUpDown.Size = new System.Drawing.Size(44, 20);
            this.rankUpDown.TabIndex = 10;
            this.rankUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rank";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(125, 151);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(206, 151);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // filesTableAdapter
            // 
            this.filesTableAdapter.ClearBeforeFill = true;
            // 
            // AddRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 194);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rankUpDown);
            this.Controls.Add(this.usedNameCombo);
            this.Controls.Add(this.usedModuleCombo);
            this.Controls.Add(this.usesNameCombo);
            this.Controls.Add(this.usesModuleCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRelation";
            this.Text = "AddRelation";
            this.Load += new System.EventHandler(this.AddRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox usesModuleCombo;
        private System.Windows.Forms.ComboBox usesNameCombo;
        private System.Windows.Forms.ComboBox usedModuleCombo;
        private System.Windows.Forms.ComboBox usedNameCombo;
        private System.Windows.Forms.NumericUpDown rankUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource modulesBindingSource;
        private System.Windows.Forms.BindingSource modulesDataSetBindingSource;
        private ModulesDataSet modulesDataSet;
        private FilesDataSet filesDataSet;
        private System.Windows.Forms.BindingSource filesBindingSource;
        private FilesDataSetTableAdapters.filesTableAdapter filesTableAdapter;
    }
}