using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace ImageControl
{
    public partial class PersonImage : UserControl
    {
        string extension = null;
        public PersonImage()
        {
            InitializeComponent();
        }

        private void arrow_MouseMove(object sender, MouseEventArgs e)
        {
            arrow.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("ImageControl.Resources.arrow2.bmp"));
        }

        private void arrow_MouseLeave(object sender, EventArgs e)
        {
            arrow.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("ImageControl.Resources.arrow1.bmp"));
        }

        private void arrow_Click(object sender, EventArgs e)
        {
            browseMenu.Show(arrow, new Point(-28, 11));
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            person.SizeMode = PictureBoxSizeMode.CenterImage;
            person.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("ImageControl.Resources.person.bmp"));
            extension = null;
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                person.SizeMode = PictureBoxSizeMode.Zoom;
                person.Image = Image.FromFile(openFileDialog.FileName);
                extension = new System.IO.FileInfo(openFileDialog.FileName).Extension;
            }
        }
    }
}
