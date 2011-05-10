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
    public partial class RelationshipsForm : Form
    {
        public RelationshipsForm()
        {
            InitializeComponent();
        }

        private void RelationshipsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'relsDataSet.rels' table. You can move, or remove it, as needed.
            this.relsTableAdapter.Fill(this.relsDataSet.rels);

        }
    }
}
