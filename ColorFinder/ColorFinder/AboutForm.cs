using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorFinder
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Program.MakeButtonStyle( this.btnClose );
            this.lblAbout.Text
                = "PC2st Color Finder "
                + Application.ProductVersion.ToString()
                + " Freeware Open Source"
                + this.lblAbout.Text;
        }

        private void AboutForm_Shown( object sender, EventArgs e )
        {
            this.txtInfo.SelectionLength = 0;
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.txtInfo.Focus();
            this.Hide();
        }

        private void lnkForum_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            System.Diagnostics.Process.Start( @"http://www.barnamenevis.org/" );
        }

        protected override void OnPaint( PaintEventArgs e )
        {
            base.OnPaint( e );
            e.Graphics.DrawRectangle( Pens.Silver, new Rectangle( e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1 ) );
        }
    }
}