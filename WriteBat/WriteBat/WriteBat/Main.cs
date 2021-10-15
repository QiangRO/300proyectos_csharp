using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WriteBat
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmCode frmcode = new frmCode(comboBox1.SelectedItem.ToString());
            frmcode.Owner = this;
            frmcode.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                txtMain.SaveFile(txtName.Text + ".bat",RichTextBoxStreamType.TextTextOleObjs);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Please Write The Name File");
            }
        }
    }
}
