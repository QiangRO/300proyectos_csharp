using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace test
{
    public partial class Form1 : Form
    {
        
        PictureBox pic;
        int[] x1 = new int[30];
        int[] y1 = new int[30];
        int[] x2 = new int[30];
        int[] y2 = new int[30];
        int locx, locy;
        int speed = 1;
        int x, y, fx, fy, count = 5;
        bool up, down = true, left, right, f, w = true;
        PictureBox food = new PictureBox();
        PictureBox[] Snake=new PictureBox[30];
        PictureBox wall_pic = new PictureBox();
        int r,g,b;
        List<PictureBox> wall = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 30)
            {
                
                if (f)
                {
                    food.Controls.Clear();
                    food.Size = new Size(10, 10);
                    food.BackColor = Color.Red;
                    Random r = new Random();
                    
                    food.Location = new Point(r.Next(this.Width - 20), r.Next(this.Height - 20));
                    fy = food.Top;
                    fx = food.Left;
                    this.Controls.Add(food);
                    f = false;
                }

                this.Text = count.ToString();
                

                for (int i = 0; i < count; i++)
                {
                    x1[i] = Snake[i].Left;
                    y1[i] = Snake[i].Top;
                }

                if (up)
                {
                    for (int i = 1; i < count; i++)
                    {
                        Snake[i].Top = y1[i - 1] ;
                        Snake[i].Left = x1[i - 1] ;
                        if (Snake[0].Top <= 0)
                        {
                            Snake[0].Top = this.Height;
                        }
                        if (Snake[0].Top + Snake[0].Height >= fy && Snake[0].Top <= fy + 5
                            && Snake[0].Left + Snake[0].Width >= fx && Snake[0].Left <= fx + 5)
                        {
                            timer2.Enabled = true;
                            f = true;
                        }
                    }Snake[0].Top -= speed;

                }
                if (down)
                {
                    for (int i = 1; i < count; i++)
                    {
                        
                        Snake[i].Top = y1[i - 1];
                        Snake[i].Left = x1[i - 1];
                        if (Snake[0].Top >= this.Height)
                        {
                            Snake[0].Top = 0;
                        }
                        if (Snake[0].Top + Snake[0].Height >= fy && Snake[0].Top <= fy + 5
                            && Snake[0].Left + Snake[0].Width >= fx && Snake[0].Left <= fx + 5)
                        {
                            f = true;
                            timer2.Enabled = true;
                        }
                    }Snake[0].Top += speed;
                }

                if (left)
                {
                    for (int i = 1; i < count; i++)
                    {
                        
                        Snake[i].Top = y1[i - 1] ;
                        Snake[i].Left = x1[i - 1];

                        if (Snake[0].Left <= 0)
                        {
                            Snake[0].Left = this.Width;
                        }
                        if (Snake[0].Top + Snake[0].Height >= fy && Snake[0].Top <= fy + 5
                            && Snake[0].Left + Snake[0].Width >= fx && Snake[0].Left <= fx + 5)
                        {
                            f = true;
                            timer2.Enabled = true;
                        }
                    }Snake[0].Left-= speed;
                }

                if (right)
                {
                    for (int i = 1; i < count; i++)
                    {
                        
                        Snake[i].Top = y1[i - 1];
                        Snake[i].Left = x1[i - 1];
                        if (Snake[0].Left >= this.Width)
                        {
                            Snake[0].Left = 0;
                        }
                        if (Snake[0].Top +Snake[0].Height  >= fy && Snake[0].Top <= fy + 5
                            && Snake[0].Left + Snake[0].Width >= fx && Snake[0].Left <= fx +5 )
                        {
                            f = true;
                            timer2.Enabled = true;
                        }
                    }Snake[0].Left  += speed;
                }
            }
            else {timer1.Enabled = false; MessageBox.Show("you win");  }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
          f = true;
          this.Controls.Clear();
          Random rnd = new Random();
          for (int i = 0; i < count; i++)
          {
              Snake[i] = new PictureBox();
              Snake[i].Size = new Size(10, 10);
              Snake[i].Location = new Point(locx, locy);
              Snake[0].BackColor = Color.GreenYellow;
              Snake[i].BackColor = Color.ForestGreen;
              this.Controls.Add(Snake[i]);
              f = true;
          }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
            if(!down)
            if (e.KeyData == Keys.Up)
            {
                up = true; down = right = left = false;
            }
            
            if(!up)
            if (e.KeyData == Keys.Down)
            {
                up = right = left = false; down = true;
            }
           
            if(!right)
            if (e.KeyData == Keys.Left)
            {
                up = false; down = false; right = false; left = true;
            }
            
            if(!left)
            if (e.KeyData == Keys.Right)
            {
                up = false; down = false; left = false; right = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count += 1;
            x = count % speed;
            locx = Snake[0].Location.X;
            locy = Snake[0].Location.Y;

            for (int i = 0; i < count; i++)
            {
                Snake[i] = new PictureBox();
                Snake[i].Controls.Clear();
            }
            Form1_Load(sender, e);
            if (f)
            {
                food.Controls.Clear();
                food.Size = new Size(10, 10);
                food.BackColor = Color.Red;
                Random r = new Random();
                food.Location = new Point(r.Next(this.Width - 20), r.Next(this.Height - 20));
                fy = food.Top;
                fx = food.Left;
                this.Controls.Add(food);
                speed++;
                f = false;
            }
            timer2.Enabled = false;
        }
    }
}
