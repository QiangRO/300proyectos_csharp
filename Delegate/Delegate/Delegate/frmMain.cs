using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Delegate
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            ExampleClass ec=new ExampleClass();
            ProcessNumber pn = new ProcessNumber(ec.DisplayNumber);
            ec.MultiplyNumbers(4, 5, pn);
        }
    }
}