using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphic_CS
{
    public partial class Form1 : Form
    {
        Graphics Graphic;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show ("Pogrammer : Alireza Zare " + "\n" + "Y-Mail : alireza_2297@yahoo.com" + "\n" + "G-Mail : jacksmith354@yahoo.com" + "\n" + "Web : www.ali-virus.blogfa.com","Information : ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Rectangle rect = new Rectangle(100, 10, 200, 200);
            Graphic.DrawArc(Pens.Blue, rect, 100, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Graphic = this.CreateGraphics();
            Point PT1 = new Point(100, 210);
            Point PT2 = new Point(240, 150);
            Point PT3 = new Point(122, 222);
            Point PT4 = new Point(124, 245);
            Graphic.DrawBezier(Pens.Red, PT1, PT2, PT3, PT4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            PointF PT1 = new PointF(190, 30);
            PointF PT2 = new PointF(240, 190);
            PointF PT3 = new PointF(122, 222);
            PointF PT4 = new PointF(124, 245);
            PointF PT5 = new PointF(158, 255);
            PointF PT6 = new PointF(184, 285);
            PointF PT7 = new PointF(248, 275);
            PointF[] AllPT ={ PT1, PT2, PT3, PT4, PT5,PT6,PT7 };
            Graphic.DrawBeziers(Pens.Gray,AllPT);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            PointF PT1 = new PointF(170, 310);
            PointF PT2 = new PointF(240, 150);
            PointF PT3 = new PointF(122, 222);
            PointF PT4 = new PointF(104, 345);
            PointF PT5 = new PointF(158, 215);
            PointF PT6 = new PointF(154, 285);
            PointF PT7 = new PointF(242, 275);
            PointF[] AllPT ={ PT1, PT2, PT3, PT4, PT5,PT6,PT7 };
            Graphic.DrawClosedCurve(Pens.Aqua, AllPT);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            PointF PT1 = new PointF(122, 210);
            PointF PT2 = new PointF(240, 150);
            PointF PT3 = new PointF(194, 21);
            PointF PT4 = new PointF(124, 145);
            PointF PT5 = new PointF(228, 355);
            PointF PT6 = new PointF(167, 285);
            PointF PT7 = new PointF(248, 275);
            PointF[] AllPT ={ PT1, PT2, PT3, PT4, PT5, PT6, PT7 };
            Graphic.DrawCurve(Pens.Gold, AllPT);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Rectangle Rect = new Rectangle(140, 15, 120, 111);
            Graphic.DrawEllipse(Pens.Black, Rect);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Icon icon=new Icon("C:\\Your_Icon.ico");
            Rectangle Rect = new Rectangle(10, 10, 48, 48);
            Graphic.DrawIcon(icon, Rect);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Point PNT_IMG = new Point(10, 10);
            Graphic.DrawImage(Image.FromFile("C:\\Your_Image.jpg"), PNT_IMG);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Graphic.DrawLine(Pens.Brown, 100, 200, 200, 100);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Point PT1 =new Point(100,150);
            Point PT2 =new Point(125,111);
            Point PT3 =new Point(287,180);
            Point PT4 =new Point(100,150);
            Point[] AllPT = {PT1,PT2,PT3,PT4};
            Graphic.DrawLines(Pens.Crimson, AllPT);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Rectangle Rect = new Rectangle(100, 200, 150, 250);
            Graphic.DrawPie(Pens.Orange, Rect, 100, 100);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Point PT1 = new Point(300, 250);
            Point PT2 = new Point(250, 360);
            Point PT3 = new Point(190, 180);
            Point PT4 = new Point(180, 150);
            Point[] AllPT ={ PT1, PT2, PT3, PT4 };
            Graphic.DrawPolygon(Pens.Sienna, AllPT);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Rectangle Rect = new Rectangle(10, 10, 200, 200);
            Graphic.DrawRectangle(Pens.Plum, Rect);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Rectangle Rect1=new Rectangle(50,50,200,200);
            Rectangle Rect2=new Rectangle(100,100,200,200);
            Rectangle[] AllRetc={Rect1,Rect2};
            Graphic.DrawRectangles(Pens.Green, AllRetc);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Font Font=new Font("Tahoma",100,FontStyle.Bold,GraphicsUnit.Pixel);
            Point PT=new Point(340,300);
            Graphic.DrawString("NETSKY", Font, Brushes.BlueViolet, PT);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Point PT1=new Point(150,100);
            Point PT2=new Point(320,120);
            Point PT3=new Point(155,158);
            Point PT4=new Point(244,243);
            Point PT5=new Point(310,420);
            Point[] AllPT={PT1,PT2,PT3,PT4,PT5};
            Graphic.FillClosedCurve(Brushes.Coral, AllPT);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Rectangle Rect=new Rectangle(10,10,250,150);
            Graphic.FillEllipse(Brushes.DodgerBlue, Rect);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Rectangle Rect=new Rectangle(600,10,150,260);
            Graphic.FillPie(Brushes.Firebrick, Rect, 150, 150);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Point PT1=new Point(189,120);
            Point PT2=new Point(220,236);
            Point PT3=new Point(364,387);
            Point PT4=new Point(121,190);
            Point[] AllPT={PT1,PT2,PT3,PT4};
            Graphic.FillPolygon(Brushes.LightPink, AllPT);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Rectangle Rect = new Rectangle(400, 100, 250, 140);
            Graphic.FillRectangle(Brushes.OliveDrab, Rect);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Graphic = this.CreateGraphics();
            Rectangle Rect1=new Rectangle(10,10,150,150);
            Rectangle Rect2=new Rectangle(90,100,150,250);
            Rectangle[] AllRects={Rect1,Rect2};
            Graphic.FillRectangles(Brushes.Turquoise, AllRects);
        }
    }
}