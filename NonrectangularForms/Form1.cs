using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NonrectangularForms
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Point mouseOffset;
		private bool isMouseDown = false;


		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 405);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			
	
		}

		private void Form1_DoubleClick(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			System.Drawing.Bitmap Img = new System.Drawing.Bitmap("PH01046J.BMP");
			//The color at Pixel(10,10) is rendered as transparent for the complete background.
			Img.MakeTransparent(Img.GetPixel(10,10));
			this.BackgroundImage = Img;
			this.TransparencyKey = Img.GetPixel(10,10);
	
		}

		private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		
			if (isMouseDown) 
			{
				Point mousePos = Control.MousePosition;
				mousePos.Offset(mouseOffset.X, mouseOffset.Y);
				Location = mousePos;
			}

		}

		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int xOffset;
			int yOffset;

			if (e.Button == MouseButtons.Left) 
			{
				xOffset = -e.X ;//- SystemInformation.FrameBorderSize.Width;
				yOffset = -e.Y ;//- SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
				mouseOffset = new Point(xOffset, yOffset);
				isMouseDown = true;
			}


		}

		private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// Changes the isMouseDown field so that the form does
			// not move unless the user is pressing the left mouse button.
			if (e.Button == MouseButtons.Left) 
			{
				isMouseDown = false;
			}

		}
	}
}
