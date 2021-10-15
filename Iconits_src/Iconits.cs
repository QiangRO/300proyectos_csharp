using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace yojanahanif
{
	/// <summary>
	/// Summary description for Iconits.
	/// </summary>
	public class Iconits : System.Windows.Forms.UserControl
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolTip t=new ToolTip();
		Bitmap[] bmp;	
		int flag;
		bool enter;
		Graphics g,g2;
		int imwidth,imheight;
		double curwidth,curheight;
		double addx,addy;
		Bitmap dblbuffer;
		bool blur=true;

		public Iconits()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call			
			bmp=new Bitmap[4];	
			for (int i=0;i<4;i++)
				bmp[i]=new Bitmap(Width,Height);
			dblbuffer=new Bitmap(Width,Height);
			IconSize=new Size(Width/2,Height/2);

			g=this.CreateGraphics();					
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Iconits
			// 
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Name = "Iconits";
			this.Size = new System.Drawing.Size(160, 128);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Iconits_Paint);
			this.MouseEnter += new System.EventHandler(this.Iconits_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.Iconits_MouseLeave);

		}
		#endregion

		private void Iconits_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{				
			draw(3);						
		}

		private void calc()
		{
			curwidth=imwidth;
			curheight=imheight;

			addx=(double)(Width-imwidth)/10;
			addy=(double)(Height-imheight)/10;
		}

		private void draw(int state)
		{
			int st;

			if (blur)
				st=state;
			else
				st=0;

			g2=Graphics.FromImage(dblbuffer);						
			g2.Clear(this.BackColor);
			g2.DrawImage(bmp[st],(int)((double)Width-curwidth)/2,(int)((double)Height-curheight)/2,(int)curwidth,(int)curheight);			
			
			g.DrawImageUnscaled(dblbuffer,0,0);			
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{				
			if (enter)
			{
				if (curwidth<Width)
				{
					curwidth+=addx;
				}

				if (curheight<Height)
				{
					curheight+=addy;
				}

				if (curwidth>=Width&&curheight>=Height) timer1.Stop();

				flag++;
			}
			else
			{
				if (curwidth>imwidth)
				{
					curwidth-=addx;
				}

				if (curheight>imheight)
				{
					curheight-=addy;
				}

				if (curwidth<=imwidth&&curheight<=imheight) timer1.Stop();

				flag--;
			}

			if (flag>9) draw(0);
			else if (flag>6) draw(1);
			else if (flag>3) draw(2);
			else draw(3);				
		}

		private void Iconits_MouseEnter(object sender, System.EventArgs e)
		{			
			enter=true;
			timer1.Start();
		}

		private void Iconits_MouseLeave(object sender, System.EventArgs e)
		{
			enter=false;		
			timer1.Start();			
		}

		public Bitmap Icon
		{
			get { return bmp[0]; }
			set { 
				for (int i=0;i<4;i++)
					bmp[i]=new Bitmap(Width,Height);
				dblbuffer=new Bitmap(Width,Height);

				bmp[0]=value; 	
				bmp[1]=alpha.returnAlpha(bmp[0],60);
				bmp[2]=alpha.returnAlpha(bmp[0],120);
				bmp[3]=alpha.returnAlpha(bmp[0],180);
				draw(0);				
			}
		}

		public new Size Size
		{
			get { return new Size(Width,Height); }
			set 
			{
				Width = ((Size)value).Width;
				Height= ((Size)value).Height;				
				if (Width>160) 
				{
					//MessageBox.Show("Width cannot exceed 160 :p");
					Width=160;
				}
				if (Height>128) 
				{
					//MessageBox.Show("Height cannot exceed 128 :p");
					Height=128;							
				}
				calc();
			}
		}	

		public Size IconSize
		{
			get { return new Size(imwidth,imheight); }
			set
			{
				imwidth=((Size)value).Width;
				imheight=((Size)value).Height;
				if (imwidth>Width) imwidth=Width;
				if (imheight>Height) imheight=Height;
				calc();
			}
		}

		public bool Blur
		{
			get { return blur; }
			set
			{
				blur=value;
				if (!blur)
				{
					bmp[1].Dispose();
					bmp[2].Dispose();
					bmp[3].Dispose();
				}
				else
				{
					bmp[1]=alpha.returnAlpha(bmp[0],60);
					bmp[2]=alpha.returnAlpha(bmp[0],120);
					bmp[3]=alpha.returnAlpha(bmp[0],180);
				}
			}
		}

		public string About
		{
			get { return "Iconits 0.1 - ITS Informatics Surabaya, author: Yojana Hanif"; }
		}

		public string TooltipText
		{
			get { return t.GetToolTip(this); }
			set { t.SetToolTip(this,value); 				
			}
		}
	}
}
