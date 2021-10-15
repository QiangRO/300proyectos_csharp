using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Autoplay_Virus_Remover
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            label1.Text = "My Simple Antivirus";
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}