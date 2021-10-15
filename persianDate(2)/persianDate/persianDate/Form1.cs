using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace persianDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            goldasht2.persianDate prsDate = new goldasht2.persianDate(DateTime.Now);
            toolStripStatusLabel1.Text = prsDate.CompletePrsDate() + prsDate.taghvim();
        }
    }
}
