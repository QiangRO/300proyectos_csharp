using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HNotePad__
{
    public partial class SearchFom : Form
    {
        private Controls.CustomForm CallerForm;

        public SearchFom(Controls.CustomForm caller)
        {
            InitializeComponent();
            CallerForm = caller;
        }

        private void SearchFom_Load(object sender, EventArgs e)
        {
            if (txbInput.Text.Length == 0)
                btnFind.Enabled = false;
        }

        private void txbInput_TextChanged(object sender, EventArgs e)
        {
            if (txbInput.Text.Length > 0)
                btnFind.Enabled = true;
            else
                btnFind.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbUpDirection_CheckedChanged(object sender, EventArgs e)
        {
            rdbDownDirection.Checked = !rdbUpDirection.Checked;
        }

        private void rdbDownDirection_CheckedChanged(object sender, EventArgs e)
        {
            rdbUpDirection.Checked = !rdbDownDirection.Checked;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            this.BringToFront();
            int Direction = (rdbUpDirection.Checked == true) ? 1 : 2;
            CallerForm.GetFindInfo(this.txbInput.Text, this.ckbMatchCase.Checked, Direction);

        }

        private void SearchFom_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnFind_Click(null, null);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
    }
}