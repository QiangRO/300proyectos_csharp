using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        #region ShowChild
        private void child1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagementHelper.ShowChild1(this);
        }

        private void child2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagementHelper.ShowChild2(this);
        }

        private void child3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagementHelper.ShowChild3(this);
        }
        #endregion
    }
}
