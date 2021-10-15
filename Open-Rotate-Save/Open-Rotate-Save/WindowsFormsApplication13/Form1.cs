using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpg image(*.jpg)|*.jpg|" + "Bmp image(*.bmp)|*.bmp|" + "Png image(*.png)|*.png|" +
                "Gif image(*.gif)|*.gif|" + "Emf image(*.emf)|*.emf|" + "Exif image(*.exif)|*.exif|" + "Icon image(*.ico)|*.ico|" +
                "Wmf image(*.wmf)|*.wmf|" + "Tiff image(*.tiff)|*.tiff|" + "All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Jpg image(*.jpg)|*.jpg|" + "Bmp image(*.bmp)|*.bmp|" + "Png image(*.png)|*.png|" +
                "Gif image(*.gif)|*.gif|" + "Emf image(*.emf)|*.emf|" + "Exif image(*.exif)|*.exif|" + "Icon image(*.ico)|*.ico|" +
                "Wmf image(*.wmf)|*.wmf|" + "Tiff image(*.tiff)|*.tiff|" + "All Files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackgroundImage.Save(saveFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackgroundImage != null)
            {
                pictureBox1.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Invalidate();
                int x = pictureBox1.Width;
                pictureBox1.Height = pictureBox1.Width;
                pictureBox1.Height = x;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Design: Vahid mirzaie", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
