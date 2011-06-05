using RegressionViewer.DataSets;
using RegressionViewer.DataSets.FilesDataSetTableAdapters;
using RegressionViewer.DataSets.ModulesDataSetTableAdapters;
namespace RegressionViewer.Forms
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
            this.usesModulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usesModulesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usesModulesDataSet = new ModulesDataSet();
            this.usedModulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usedModulesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usedModulesDataSet = new ModulesDataSet();
            this.usesNameCombo = new System.Windows.Forms.ComboBox();
            this.usesFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usesFilesDataSet = new FilesDataSet();
            this.usedFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usedFilesDataSet = new FilesDataSet();
            this.usedModuleCombo = new System.Windows.Forms.ComboBox();
            this.usedNameCombo = new System.Windows.Forms.ComboBox();
            this.rateUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.filesTableAdapter = new filesTableAdapter();
            this.modulesTableAdapter = new modulesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usesModulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usesModulesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usesModulesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedModulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedModulesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedModulesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usesFilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usesFilesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedFilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedFilesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateUpDown)).BeginInit();
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
            this.usesModuleCombo.DataSource = this.usesModulesBindingSource;
            this.usesModuleCombo.DisplayMember = "name";
            this.usesModuleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usesModuleCombo.FormattingEnabled = true;
            this.usesModuleCombo.Location = new System.Drawing.Point(160, 13);
            this.usesModuleCombo.Name = "usesModuleCombo";
            this.usesModuleCombo.Size = new System.Drawing.Size(208, 21);
            this.usesModuleCombo.TabIndex = 6;
            this.usesModuleCombo.ValueMember = "id";
            this.usesModuleCombo.SelectedIndexChanged += new System.EventHandler(this.fillFilesUsingParametrizedQuery);
            // 
            // usesModulesBindingSource
            // 
            this.usesModulesBindingSource.DataMember = "modules";
            this.usesModulesBindingSource.DataSource = this.usesModulesDataSetBindingSource;
            // 
            // usesModulesDataSetBindingSource
            // 
            this.usesModulesDataSetBindingSource.DataSource = this.usesModulesDataSet;
            this.usesModulesDataSetBindingSource.Position = 0;
            // 
            // usesModulesDataSet
            // 
            this.usesModulesDataSet.DataSetName = "ModulesDataSet";
            this.usesModulesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usedModulesBindingSource
            // 
            this.usedModulesBindingSource.DataMember = "modules";
            this.usedModulesBindingSource.DataSource = this.usedModulesDataSetBindingSource;
            // 
            // usedModulesDataSetBindingSource
            // 
            this.usedModulesDataSetBindingSource.DataSource = this.usedModulesDataSet;
            this.usedModulesDataSetBindingSource.Position = 0;
            // 
            // usedModulesDataSet
            // 
            this.usedModulesDataSet.DataSetName = "ModulesDataSet";
            this.usedModulesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usesNameCombo
            // 
            this.usesNameCombo.DataSource = this.usesFilesBindingSource;
            this.usesNameCombo.DisplayMember = "name";
            this.usesNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usesNameCombo.FormattingEnabled = true;
            this.usesNameCombo.Location = new System.Drawing.Point(160, 41);
            this.usesNameCombo.Name = "usesNameCombo";
            this.usesNameCombo.Size = new System.Drawing.Size(208, 21);
            this.usesNameCombo.TabIndex = 7;
            this.usesNameCombo.ValueMember = "id";
            // 
            // usesFilesBindingSource
            // 
            this.usesFilesBindingSource.DataMember = "files";
            this.usesFilesBindingSource.DataSource = this.usesFilesDataSet;
            // 
            // usesFilesDataSet
            // 
            this.usesFilesDataSet.DataSetName = "usesFilesDataSet";
            this.usesFilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usedFilesBindingSource
            // 
            this.usedFilesBindingSource.DataMember = "files";
            this.usedFilesBindingSource.DataSource = this.usedFilesDataSet;
            // 
            // usedFilesDataSet
            // 
            this.usedFilesDataSet.DataSetName = "usedFilesDataSet";
            this.usedFilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usedModuleCombo
            // 
            this.usedModuleCombo.DataSource = this.usedModulesBindingSource;
            this.usedModuleCombo.DisplayMember = "name";
            this.usedModuleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usedModuleCombo.FormattingEnabled = true;
            this.usedModuleCombo.Location = new System.Drawing.Point(160, 70);
            this.usedModuleCombo.Name = "usedModuleCombo";
            this.usedModuleCombo.Size = new System.Drawing.Size(208, 21);
            this.usedModuleCombo.TabIndex = 8;
            this.usedModuleCombo.ValueMember = "id";
            this.usedModuleCombo.SelectedIndexChanged += new System.EventHandler(this.fillFilesUsingParametrizedQuery);
            // 
            // usedNameCombo
            // 
            this.usedNameCombo.DataSource = this.usedFilesBindingSource;
            this.usedNameCombo.DisplayMember = "name";
            this.usedNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usedNameCombo.FormattingEnabled = true;
            this.usedNameCombo.Location = new System.Drawing.Point(160, 97);
            this.usedNameCombo.Name = "usedNameCombo";
            this.usedNameCombo.Size = new System.Drawing.Size(208, 21);
            this.usedNameCombo.TabIndex = 9;
            this.usedNameCombo.ValueMember = "id";
            // 
            // rateUpDown
            // 
            this.rateUpDown.Location = new System.Drawing.Point(160, 125);
            this.rateUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rateUpDown.Name = "rateUpDown";
            this.rateUpDown.Size = new System.Drawing.Size(44, 20);
            this.rateUpDown.TabIndex = 10;
            this.rateUpDown.Value = new decimal(new int[] {
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
            this.AddButton.Location = new System.Drawing.Point(212, 148);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(293, 148);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // filesTableAdapter
            // 
            this.filesTableAdapter.ClearBeforeFill = true;
            // 
            // modulesTableAdapter
            // 
            this.modulesTableAdapter.ClearBeforeFill = true;
            // 
            // AddRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 180);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rateUpDown);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Relation";
            this.Load += new System.EventHandler(this.AddRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usesModulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usesModulesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usesModulesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedModulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedModulesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedModulesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usesFilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usesFilesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedFilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedFilesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateUpDown)).EndInit();
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
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.ComboBox usesModuleCombo;
        private System.Windows.Forms.ComboBox usesNameCombo;
        private System.Windows.Forms.ComboBox usedModuleCombo;
        private System.Windows.Forms.ComboBox usedNameCombo;
        private System.Windows.Forms.NumericUpDown rateUpDown;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button cancelButton;
        
        private modulesTableAdapter modulesTableAdapter;
        private System.Windows.Forms.BindingSource usesModulesBindingSource;
        private System.Windows.Forms.BindingSource usesModulesDataSetBindingSource;
        private System.Windows.Forms.BindingSource usedModulesBindingSource;
        private System.Windows.Forms.BindingSource usedModulesDataSetBindingSource;
        private ModulesDataSet usesModulesDataSet;
        private ModulesDataSet usedModulesDataSet;


        private filesTableAdapter filesTableAdapter;
        private System.Windows.Forms.BindingSource usesFilesBindingSource;
        private System.Windows.Forms.BindingSource usedFilesBindingSource;
        private FilesDataSet usesFilesDataSet;
        private FilesDataSet usedFilesDataSet;
        
    }
}