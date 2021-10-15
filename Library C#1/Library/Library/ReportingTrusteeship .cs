using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class ReportingTrusteeship : Form
    {
        public ReportingTrusteeship()
        {
            InitializeComponent();
        }

        private void sabteAmanatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sabteAmanatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void ReportingTrusteeship_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.SabteAmanat' table. You can move, or remove it, as needed.
            this.sabteAmanatTableAdapter.Fill(this.libraryDataSet.SabteAmanat);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            trusteeshipRegister trustee = new trusteeshipRegister();
            trustee.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditTrusteeshipRegister edit = new EditTrusteeshipRegister();
            edit.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrusteeshipSearch search = new TrusteeshipSearch();
            search.ShowDialog(this);
        }
    }
}
