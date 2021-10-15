using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Reflection;

namespace Scrolling
{

    public class Scrolling : System.Windows.Forms.Form
    {
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MainMenu mainMenu1;

        public Scrolling()
        {

            InitializeComponent();

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Pen blackpen = new Pen(Color.Black);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.Gainsboro), 0, 0, bmp.Width, bmp.Height);
            g.DrawLine(blackpen, 0, 0, bmp.Width, bmp.Height);
            g.DrawLine(blackpen, 0, bmp.Height, bmp.Width, 0);
            g.Dispose();

            this.pictureBox1.Image = bmp;
            this.pictureBox1.Size = bmp.Size;
            this.vScrollBar1.Maximum = bmp.Height + this.ClientSize.Height;
            this.hScrollBar1.Maximum = bmp.Width + this.ClientSize.Width;
            this.hScrollBar1.Value = 0;

            this.Text = "x = 0, y = 0";
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            //
            // hScrollBar1
            //
            this.hScrollBar1.LargeChange = 240;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 255);
            this.hScrollBar1.Maximum = 493;
            this.hScrollBar1.Size = new System.Drawing.Size(227, 13);
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            //
            // vScrollBar1
            //
            this.vScrollBar1.LargeChange = 268;
            this.vScrollBar1.Location = new System.Drawing.Point(227, 0);
            this.vScrollBar1.Maximum = 549;
            this.vScrollBar1.Size = new System.Drawing.Size(13, 255);
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            //
            // panel1
            //
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Size = new System.Drawing.Size(480, 536);
            //
            // pictureBox1
            //
            this.pictureBox1.Location = new System.Drawing.Point(88, 36);
            this.pictureBox1.Size = new System.Drawing.Size(304, 464);
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.Text = "Top Left";
            //
            // label2
            //
            this.label2.Location = new System.Drawing.Point(400, 8);
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.Text = "Top Right";
            //
            // label3
            //
            this.label3.Location = new System.Drawing.Point(8, 508);
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.Text = "Bottom Left";
            //
            // label4
            //
            this.label4.Location = new System.Drawing.Point(400, 508);
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.Text = "Bottom Right";
            //
            // Scrolling
            //
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.panel1);
            this.Menu = this.mainMenu1;
            this.Text = "Scrolling";

        }

        static void Main()
        {
            Application.Run(new Scrolling());
        }

        private void hScrollBar1_ValueChanged(object sender, System.EventArgs e)
        {
            this.panel1.Left = -this.hScrollBar1.Value;

            // Display the current values in the title bar.
            this.Text = "x = " + this.panel1.Location.X + ", y = " + this.panel1.Location.Y;
        }

        private void vScrollBar1_ValueChanged(object sender, System.EventArgs e)
        {
            this.panel1.Top = -this.vScrollBar1.Value;

            // Display the current values in the title bar.
            this.Text = "x = " + this.panel1.Location.X + ", y = " + this.panel1.Location.Y;
        }
    }
}