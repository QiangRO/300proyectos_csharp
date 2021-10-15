using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FarsiMessageBox
{
    public partial class MsgBox : Form
    {
        private DialogResult _result;
        public MsgBox()
        {
            InitializeComponent();
        }

        public DialogResult Result
        {
            get { return _result; }
        }
        
        public Label label
        {
            get { return _label; }
            set { _label = value; }
        }

        public PictureBox icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        public Panel OKPanel
        {
            get { return _okPanel; }
            set { _okPanel = value; }
        }

        public Panel OKCancelPanel
        {
            get { return _okCancelPanel; }
            set { _okCancelPanel = value; }
        }

        public Panel RetryCancelPanel
        {
            get { return _retryCancelPanel; }
            set { _retryCancelPanel = value; }
        }

        public Panel YesNoPanel
        {
            get { return _yesNoPanel; }
            set { _yesNoPanel = value; }
        }

        public Panel YesNoCancelPanel
        {
            get { return _yesNoCancelPanel; }
            set { _yesNoCancelPanel = value; }
        }
        
        private void okPanelOKBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.OK;
            this.Close();
        }

        private void okCancelPanelCancelBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Cancel;
            this.Close();
        }

        private void retryCancelPanelCancelBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Cancel;
            this.Close();
        }

        private void yesNoCancelPanelCancelBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Cancel;
            this.Close();
        }

        private void okPanelOKBtn_Click_1(object sender, EventArgs e)
        {
            _result = DialogResult.OK;
            this.Close();
        }

        private void okCancelPanelOKBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.OK;
            this.Close();
        }

        private void retryCancelPanelRetryBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Retry;
            this.Close();
        }

        private void yesNoCancelPanelNoBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.No;
            this.Close();
        }

        private void yesNoCancelPanelYesBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Yes;
            this.Close();
        }

        private void yesNoPanelNoBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.No;
            this.Close();
        }

        private void yesNoPanelYesBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Yes;
            this.Close();
        }
    }
}