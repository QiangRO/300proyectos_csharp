using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nagative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bimpx, bimpy;
        Color lng;
        private void button1_Click(object sender, EventArgs e)
        {
            string x;
            openFileDialog1.ShowDialog();
            x = System.Windows.Forms.DialogResult.OK.ToString();
            if (x == "OK")
            {

                pictureBox1.Load(openFileDialog1.FileName);


                bimpx = new Bitmap(openFileDialog1.FileName, true);
                if ((bimpx.Height > pictureBox1.Height) && (bimpx.Width > pictureBox1.Width))
                {
                    pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                }

                bimpy = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bimpy.Save(saveFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < bimpx.Width; i++)
            {
                for (j = 0; j < bimpx.Height; j++)
                {
                    lng = bimpx.GetPixel(i, j);
                    if (255 > (lng.R + lng.G + lng.B))
                    {
                        bimpy.SetPixel(i, j, Color.FromArgb(255 - (lng.R + lng.G + lng.B), 255 - (lng.R + lng.G + lng.B), 255 - (lng.R + lng.G + lng.B)));
                    }
                   
                    else 
                    {
                        bimpy.SetPixel(i, j, lng);
                    }
                }
            }
            pictureBox2.Image = bimpy;
            if ((bimpx.Height > pictureBox1.Height) && (bimpx.Width > pictureBox1.Width))
            {
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < bimpx.Width; i++)
            {
                for (j = 0; j < bimpx.Height; j++)
                {
                    lng = bimpx.GetPixel(i, j);
                    if (255 > (lng.R + lng.G + lng.B))
                    {
                        bimpy.SetPixel(i, j, Color.FromArgb(255 - (lng.R + lng.G + lng.B), 255 - (lng.R + lng.G + lng.B), 255 - (lng.R + lng.G + lng.B)));
                    }
                    else if (255 <= (lng.R + lng.G + lng.B))
                    {
                        bimpy.SetPixel(i, j, Color.FromArgb((0), (0), (0)));
                    }
                    else
                    {
                        bimpy.SetPixel(i, j, lng);
                    }
                }
            }
            pictureBox2.Image = bimpy;
            if ((bimpx.Height > pictureBox1.Height) && (bimpx.Width > pictureBox1.Width))
            {
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
        }
    }
}