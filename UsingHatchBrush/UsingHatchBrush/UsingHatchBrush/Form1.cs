using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace UsingHatchBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
      
        private void pictureBoxes_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                
                PictureBox senderItem = sender as PictureBox; //Detect pictrueBox Which Raiesd this event


                //create a hBrush
                System.Drawing.Drawing2D.HatchBrush hBrush = new HatchBrush((HatchStyle)(Enum.Parse(typeof(HatchStyle), senderItem.Tag.ToString(), true)), Color.Red, Color.Green);

                //draw FillRectangle With hBrush on the Source Item
                e.Graphics.FillRectangle(hBrush, senderItem.ClientRectangle);

                //Calculate Size Of Text
                SizeF textSize = e.Graphics.MeasureString(senderItem.Tag.ToString().Trim(), this.Font);

                int X_Loc = (int)(senderItem.Width - textSize.Width) / 2;
                int Y_LOc = (int)(senderItem.Height - textSize.Height) / 2;

                //Draw text
                e.Graphics.DrawString(senderItem.Tag.ToString().Trim(), this.Font, new SolidBrush(this.ForeColor), X_Loc, Y_LOc);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}