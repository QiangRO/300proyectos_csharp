using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace print_preview1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button print;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.PictureBox pic1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.print = new System.Windows.Forms.Button();
			this.lbl1 = new System.Windows.Forms.Label();
			this.pic1 = new System.Windows.Forms.PictureBox();
			this.lbl2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// print
			// 
			this.print.Location = new System.Drawing.Point(304, 512);
			this.print.Name = "print";
			this.print.Size = new System.Drawing.Size(112, 56);
			this.print.TabIndex = 0;
			this.print.Text = "button1";
			this.print.Click += new System.EventHandler(this.print_Click);
			// 
			// lbl1
			// 
			this.lbl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbl1.Font = new System.Drawing.Font("Zar", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.lbl1.ForeColor = System.Drawing.Color.Crimson;
			this.lbl1.Location = new System.Drawing.Point(128, 8);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(456, 88);
			this.lbl1.TabIndex = 1;
			this.lbl1.Text = "  „Õ”‰ ÌÊ‰”Ì ¬—«¡";
			this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pic1
			// 
			this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
			this.pic1.Location = new System.Drawing.Point(192, 128);
			this.pic1.Name = "pic1";
			this.pic1.Size = new System.Drawing.Size(336, 272);
			this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic1.TabIndex = 2;
			this.pic1.TabStop = false;
			this.pic1.Click += new System.EventHandler(this.pic1_Click);
			// 
			// lbl2
			// 
			this.lbl2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbl2.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl2.ForeColor = System.Drawing.Color.Crimson;
			this.lbl2.Location = new System.Drawing.Point(192, 408);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(336, 88);
			this.lbl2.TabIndex = 1;
			this.lbl2.Text = "mohsen_araa";
			this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(672, 573);
			this.Controls.Add(this.pic1);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.print);
			this.Controls.Add(this.lbl2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

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

		private void print_Click(object sender, System.EventArgs e)
		{
			System.Drawing.Printing.PrintDocument PrintDoc=new System.Drawing.Printing.PrintDocument();
			PageSetupDialog PageSetupDialog1=new PageSetupDialog();
			PrintPreviewDialog PreviewDialog=new PrintPreviewDialog();

			
			PrintDoc.OriginAtMargins=true;
			PrintDoc.DefaultPageSettings=PageSetupDialog1.PageSettings;
			PrintDoc.PrintPage+=new System.Drawing.Printing.PrintPageEventHandler(PrintDoc_Print);
			PageSetupDialog1.Document=PrintDoc;
			PageSetupDialog1.ShowDialog();

			PreviewDialog.Document=PrintDoc;
			PreviewDialog.AllowTransparency=true;
			PreviewDialog.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			PreviewDialog.ShowDialog();

			PrintDoc.Dispose();
			PreviewDialog.Dispose();
			PageSetupDialog1.Dispose();
		}
		private void PrintDoc_Print(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
		DrawControls(e);
		}
		private void DrawControls( System.Drawing.Printing.PrintPageEventArgs e)
		{
			System.Drawing.SolidBrush 	SBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
			System.Drawing.Rectangle Rect = new System.Drawing.Rectangle(lbl1.Left , lbl1.Top, lbl1.Width, lbl1.Height);
			System.Drawing.Region Region1 = new System.Drawing.Region(Rect);
			e.Graphics.FillRegion(SBrush, Region1);

			SBrush = new System.Drawing.SolidBrush(lbl1.ForeColor);
			System.Drawing.SizeF oSizeF = e.Graphics.MeasureString(lbl1.Text, lbl1.Font);
			e.Graphics.DrawString(lbl1.Text, lbl1.Font,SBrush, lbl1.Left, lbl1.Top,System.Drawing.StringFormat.GenericDefault);
			///e.Graphics.DrawString(lblCurrent.Text, lblCurrent.Font, oSolidBrush, lblCurrent.Left + e.MarginBounds.Left + (lblCurrent.Width - oSizeF.Width) / 2, 950 + e.MarginBounds.Top + 2, System.Drawing.StringFormat.GenericDefault);
			
			
		
			
			
			SBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
			Rect = new System.Drawing.Rectangle(lbl2.Left , lbl2.Top, lbl2.Width, lbl2.Height);
			Region1 = new System.Drawing.Region(Rect);
			e.Graphics.FillRegion(SBrush, Region1);

            			
			SBrush = new System.Drawing.SolidBrush(lbl2.ForeColor);
			oSizeF = e.Graphics.MeasureString(lbl2.Text, lbl2.Font);
			e.Graphics.DrawString(lbl2.Text, lbl2.Font,SBrush, lbl2.Left, lbl2.Top,System.Drawing.StringFormat.GenericDefault);
			
			Rect =new Rectangle(pic1.Left,pic1.Top,pic1.Width,pic1.Height);
            Region1=new Region(Rect);
			e.Graphics.FillRegion(SBrush,Region1);

			e.Graphics.DrawImage(pic1.Image,Rect);
			Region1.Dispose();
			SBrush.Dispose();

	
		}

		private void pic1_Click(object sender, System.EventArgs e)
		{
		
		}
		}
}
