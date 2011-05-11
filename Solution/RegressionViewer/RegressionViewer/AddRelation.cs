using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegressionViewer
{
    public partial class AddRelation : Form
    {
        public AddRelation()
        {
            InitializeComponent();
        }

        private void AddRelation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filesDataSet.files' table. You can move, or remove it, as needed.
            this.filesTableAdapter.Fill(this.filesDataSet.files);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.filesTableAdapter.FillBy1(this.filesDataSet.files, new System.Nullable<long>(((long)(System.Convert.ChangeType(usesModuleCombo.SelectedValue, typeof(long))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
