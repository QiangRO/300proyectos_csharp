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
    public partial class MainFormPanel : Form
    {
        public MainFormPanel()
        {
            InitializeComponent();
            bebmaxDate.persianDate pd = new bebmaxDate.persianDate(DateTime .Now );
            toolStripStatusLabel1.Text = pd.CompletePrsDate();
        }

        private void MainFormPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
