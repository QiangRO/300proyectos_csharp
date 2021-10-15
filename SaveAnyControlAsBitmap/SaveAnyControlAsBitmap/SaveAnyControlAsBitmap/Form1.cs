using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SaveAnyControlAsBitmap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveAsBitmap(this, "C:\\myPicture.bmp");
        }

        public void SaveAsBitmap(Control control, string fileName)
        {
            //getthe instance of the graphics from the control
            Graphics g = control.CreateGraphics();

            //new bitmap object to save the image
            Bitmap bmp = new Bitmap(control.Width, control.Height);

            //Drawing control to the bitmap
            control.DrawToBitmap(bmp, new Rectangle(0, 0, control.Width, control.Height));

            bmp.Save(fileName);
            bmp.Dispose();
        }
    }
}