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
    public partial class ReplaceForm : Form
    {

        private Controls.CustomForm CallerForm;

        public ReplaceForm(Controls.CustomForm caller)
        {

            InitializeComponent();

            this.CallerForm = caller;
            this.btnNextResult.Enabled =
            this.btnReplaceAll.Enabled =
            this.btnReplaceOne.Enabled = false;

        }

        private void ReplaceForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    btnNextResult_Click(null,null);
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextResult_Click(object sender, EventArgs e)
        {
            CallerForm.GetReplaceInfo(this.ckbMatchCase.Checked,
                                      txbInputString.Text,
                                      txbReplaceString.Text);
        }

        private void btnReplaceOne_Click(object sender, EventArgs e)
        {
            ReplaceAction(false);
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            ReplaceAction(true);
        }
        private void ReplaceAction(bool ReplaceAll)
        {
            btnNextResult_Click(null, null);

            if (this.CallerForm.IsDocumentHaveAnswer)
            {
                this.CallerForm.ReplaceTextInTextBoxes(ReplaceAll);
            }
            else
            {
                if (this.txbInputString.TextLength > 0)
                {
                    CallerForm.GetReplaceInfo(this.ckbMatchCase.Checked,
                                      txbInputString.Text,
                                      txbReplaceString.Text);
                    ReplaceAction(ReplaceAll);
                }
                else
                    MessageBox.Show("لطفا بخش پیدا کن را کامل کن");
            }
        }

        private void txbInputString_TextChanged(object sender, EventArgs e)
        {
            this.btnReplaceAll.Enabled =
            this.btnReplaceOne.Enabled =
            this.btnNextResult.Enabled = (this.txbInputString.TextLength > 0) ? true : false;

        }
    }
}
