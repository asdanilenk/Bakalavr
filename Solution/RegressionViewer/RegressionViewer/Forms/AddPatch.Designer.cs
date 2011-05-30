namespace RegressionViewer.Forms
{
    partial class AddPatch
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
            this.selectFileButton = new System.Windows.Forms.Button();
            this.patchFileTextBox = new System.Windows.Forms.TextBox();
            this.SCGroupBox = new System.Windows.Forms.GroupBox();
            this.regexTextBox = new System.Windows.Forms.TextBox();
            this.OtherRadioButton = new System.Windows.Forms.RadioButton();
            this.GITRadioButton = new System.Windows.Forms.RadioButton();
            this.SVNRadioButton = new System.Windows.Forms.RadioButton();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.changesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.patchNameTextBox = new System.Windows.Forms.TextBox();
            this.filesGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCGroupBox.SuspendLayout();
            this.fileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changesDataGridView)).BeginInit();
            this.nameGroupBox.SuspendLayout();
            this.previewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(190, 17);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(34, 23);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "...";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // patchFileTextBox
            // 
            this.patchFileTextBox.Enabled = false;
            this.patchFileTextBox.Location = new System.Drawing.Point(6, 19);
            this.patchFileTextBox.Name = "patchFileTextBox";
            this.patchFileTextBox.Size = new System.Drawing.Size(178, 20);
            this.patchFileTextBox.TabIndex = 1;
            // 
            // SCGroupBox
            // 
            this.SCGroupBox.Controls.Add(this.regexTextBox);
            this.SCGroupBox.Controls.Add(this.OtherRadioButton);
            this.SCGroupBox.Controls.Add(this.GITRadioButton);
            this.SCGroupBox.Controls.Add(this.SVNRadioButton);
            this.SCGroupBox.Location = new System.Drawing.Point(13, 12);
            this.SCGroupBox.Name = "SCGroupBox";
            this.SCGroupBox.Size = new System.Drawing.Size(233, 94);
            this.SCGroupBox.TabIndex = 2;
            this.SCGroupBox.TabStop = false;
            this.SCGroupBox.Text = "Source Control";
            // 
            // regexTextBox
            // 
            this.regexTextBox.Enabled = false;
            this.regexTextBox.Location = new System.Drawing.Point(68, 64);
            this.regexTextBox.Name = "regexTextBox";
            this.regexTextBox.Size = new System.Drawing.Size(140, 20);
            this.regexTextBox.TabIndex = 3;
            this.regexTextBox.Text = "<.Net regex (M\\s*(.+))>";
            // 
            // OtherRadioButton
            // 
            this.OtherRadioButton.AutoSize = true;
            this.OtherRadioButton.Location = new System.Drawing.Point(11, 65);
            this.OtherRadioButton.Name = "OtherRadioButton";
            this.OtherRadioButton.Size = new System.Drawing.Size(51, 17);
            this.OtherRadioButton.TabIndex = 2;
            this.OtherRadioButton.Text = "Other";
            this.OtherRadioButton.UseVisualStyleBackColor = true;
            this.OtherRadioButton.CheckedChanged += new System.EventHandler(this.OtherRadioButton_CheckedChanged);
            // 
            // GITRadioButton
            // 
            this.GITRadioButton.AutoSize = true;
            this.GITRadioButton.Location = new System.Drawing.Point(11, 42);
            this.GITRadioButton.Name = "GITRadioButton";
            this.GITRadioButton.Size = new System.Drawing.Size(219, 17);
            this.GITRadioButton.TabIndex = 1;
            this.GITRadioButton.Text = "GIT (git log --name-status --pretty=format:)";
            this.GITRadioButton.UseVisualStyleBackColor = true;
            // 
            // SVNRadioButton
            // 
            this.SVNRadioButton.AutoSize = true;
            this.SVNRadioButton.Checked = true;
            this.SVNRadioButton.Location = new System.Drawing.Point(11, 19);
            this.SVNRadioButton.Name = "SVNRadioButton";
            this.SVNRadioButton.Size = new System.Drawing.Size(134, 17);
            this.SVNRadioButton.TabIndex = 0;
            this.SVNRadioButton.TabStop = true;
            this.SVNRadioButton.Text = "SVN (svn log -v -r N:M)";
            this.SVNRadioButton.UseVisualStyleBackColor = true;
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Controls.Add(this.patchFileTextBox);
            this.fileGroupBox.Controls.Add(this.selectFileButton);
            this.fileGroupBox.Location = new System.Drawing.Point(13, 112);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(230, 47);
            this.fileGroupBox.TabIndex = 3;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "Patch file";
            // 
            // changesDataGridView
            // 
            this.changesDataGridView.AllowUserToAddRows = false;
            this.changesDataGridView.AllowUserToDeleteRows = false;
            this.changesDataGridView.AllowUserToResizeColumns = false;
            this.changesDataGridView.AllowUserToResizeRows = false;
            this.changesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.changesDataGridView.ColumnHeadersVisible = false;
            this.changesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filesGridViewColumn});
            this.changesDataGridView.Location = new System.Drawing.Point(6, 19);
            this.changesDataGridView.Name = "changesDataGridView";
            this.changesDataGridView.ReadOnly = true;
            this.changesDataGridView.RowHeadersVisible = false;
            this.changesDataGridView.Size = new System.Drawing.Size(218, 107);
            this.changesDataGridView.TabIndex = 4;
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.changesDataGridView);
            this.nameGroupBox.Location = new System.Drawing.Point(13, 218);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(230, 132);
            this.nameGroupBox.TabIndex = 5;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Preview";
            // 
            // OKButton
            // 
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(81, 356);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "Add";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(168, 356);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // previewGroupBox
            // 
            this.previewGroupBox.Controls.Add(this.patchNameTextBox);
            this.previewGroupBox.Location = new System.Drawing.Point(16, 165);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Size = new System.Drawing.Size(230, 47);
            this.previewGroupBox.TabIndex = 4;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Patch name";
            // 
            // patchNameTextBox
            // 
            this.patchNameTextBox.Location = new System.Drawing.Point(6, 19);
            this.patchNameTextBox.Name = "patchNameTextBox";
            this.patchNameTextBox.Size = new System.Drawing.Size(215, 20);
            this.patchNameTextBox.TabIndex = 1;
            // 
            // filesGridViewColumn
            // 
            this.filesGridViewColumn.HeaderText = "Files";
            this.filesGridViewColumn.Name = "filesGridViewColumn";
            this.filesGridViewColumn.ReadOnly = true;
            this.filesGridViewColumn.Width = 215;
            // 
            // AddPatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 384);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.fileGroupBox);
            this.Controls.Add(this.SCGroupBox);
            this.Name = "AddPatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Patch";
            this.SCGroupBox.ResumeLayout(false);
            this.SCGroupBox.PerformLayout();
            this.fileGroupBox.ResumeLayout(false);
            this.fileGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changesDataGridView)).EndInit();
            this.nameGroupBox.ResumeLayout(false);
            this.previewGroupBox.ResumeLayout(false);
            this.previewGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox patchFileTextBox;
        private System.Windows.Forms.GroupBox SCGroupBox;
        private System.Windows.Forms.TextBox regexTextBox;
        private System.Windows.Forms.RadioButton OtherRadioButton;
        private System.Windows.Forms.RadioButton GITRadioButton;
        private System.Windows.Forms.RadioButton SVNRadioButton;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.DataGridView changesDataGridView;
        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox previewGroupBox;
        private System.Windows.Forms.TextBox patchNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesGridViewColumn;
    }
}