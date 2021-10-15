using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FiFa
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            try
            {
                TextReader tr = new StreamReader("Help.txt", Encoding.UTF8);
                helpText.Text = tr.ReadToEnd();
                tr.Close();
                helpText.Focus();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
