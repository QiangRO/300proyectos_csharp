using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Iconits_demo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private yojanahanif.Iconits iconits1;
		private yojanahanif.Iconits iconits2;
		private yojanahanif.Iconits iconits3;
		private yojanahanif.Iconits iconits4;
		private yojanahanif.Iconits iconits5;
		private yojanahanif.Iconits iconits6;
		private yojanahanif.Iconits iconits7;
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
			this.iconits1 = new yojanahanif.Iconits();
			this.iconits2 = new yojanahanif.Iconits();
			this.iconits3 = new yojanahanif.Iconits();
			this.iconits4 = new yojanahanif.Iconits();
			this.iconits5 = new yojanahanif.Iconits();
			this.iconits6 = new yojanahanif.Iconits();
			this.iconits7 = new yojanahanif.Iconits();
			this.SuspendLayout();
			// 
			// iconits1
			// 
			this.iconits1.BackColor = System.Drawing.SystemColors.Control;
			this.iconits1.Blur = true;
			this.iconits1.Icon = ((System.Drawing.Bitmap)(resources.GetObject("iconits1.Icon")));
			this.iconits1.IconSize = new System.Drawing.Size(32, 32);
			this.iconits1.Location = new System.Drawing.Point(24, 16);
			this.iconits1.Name = "iconits1";
			this.iconits1.Size = new System.Drawing.Size(64, 56);
			this.iconits1.TabIndex = 0;
			this.iconits1.TooltipText = "Iconits Icon 1";
			// 
			// iconits2
			// 
			this.iconits2.BackColor = System.Drawing.SystemColors.Control;
			this.iconits2.Blur = true;
			this.iconits2.Icon = ((System.Drawing.Bitmap)(resources.GetObject("iconits2.Icon")));
			this.iconits2.IconSize = new System.Drawing.Size(32, 32);
			this.iconits2.Location = new System.Drawing.Point(88, 16);
			this.iconits2.Name = "iconits2";
			this.iconits2.Size = new System.Drawing.Size(64, 56);
			this.iconits2.TabIndex = 1;
			this.iconits2.TooltipText = "Iconits Icon 2";
			// 
			// iconits3
			// 
			this.iconits3.BackColor = System.Drawing.SystemColors.Control;
			this.iconits3.Blur = true;
			this.iconits3.Icon = ((System.Drawing.Bitmap)(resources.GetObject("iconits3.Icon")));
			this.iconits3.IconSize = new System.Drawing.Size(32, 32);
			this.iconits3.Location = new System.Drawing.Point(152, 16);
			this.iconits3.Name = "iconits3";
			this.iconits3.Size = new System.Drawing.Size(64, 56);
			this.iconits3.TabIndex = 2;
			this.iconits3.TooltipText = "Iconits Icon 3";
			// 
			// iconits4
			// 
			this.iconits4.BackColor = System.Drawing.SystemColors.Control;
			this.iconits4.Blur = true;
			this.iconits4.Icon = ((System.Drawing.Bitmap)(resources.GetObject("iconits4.Icon")));
			this.iconits4.IconSize = new System.Drawing.Size(32, 32);
			this.iconits4.Location = new System.Drawing.Point(216, 16);
			this.iconits4.Name = "iconits4";
			this.iconits4.Size = new System.Drawing.Size(64, 56);
			this.iconits4.TabIndex = 3;
			this.iconits4.TooltipText = "Iconits Icon 4";
			// 
			// iconits5
			// 
			this.iconits5.BackColor = System.Drawing.SystemColors.Control;
			this.iconits5.Blur = true;
			this.iconits5.Icon = ((System.Drawing.Bitmap)(resources.GetObject("iconits5.Icon")));
			this.iconits5.IconSize = new System.Drawing.Size(32, 32);
			this.iconits5.Location = new System.Drawing.Point(280, 16);
			this.iconits5.Name = "iconits5";
			this.iconits5.Size = new System.Drawing.Size(64, 56);
			this.iconits5.TabIndex = 4;
			this.iconits5.TooltipText = "Iconits Icon 5";
			// 
			// iconits6
			// 
			this.iconits6.BackColor = System.Drawing.SystemColors.Control;
			this.iconits6.Blur = true;
			this.iconits6.Icon = ((System.Drawing.Bitmap)(resources.GetObject("iconits6.Icon")));
			this.iconits6.IconSize = new System.Drawing.Size(32, 32);
			this.iconits6.Location = new System.Drawing.Point(344, 16);
			this.iconits6.Name = "iconits6";
			this.iconits6.Size = new System.Drawing.Size(64, 56);
			this.iconits6.TabIndex = 5;
			this.iconits6.TooltipText = "Iconits Icon 6";
			// 
			// iconits7
			// 
			this.iconits7.BackColor = System.Drawing.SystemColors.Control;
			this.iconits7.Blur = true;
			this.iconits7.Icon = ((System.Drawing.Bitmap)(resources.GetObject("iconits7.Icon")));
			this.iconits7.IconSize = new System.Drawing.Size(32, 32);
			this.iconits7.Location = new System.Drawing.Point(408, 16);
			this.iconits7.Name = "iconits7";
			this.iconits7.Size = new System.Drawing.Size(64, 56);
			this.iconits7.TabIndex = 6;
			this.iconits7.TooltipText = "Iconits Icon 7";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 262);
			this.Controls.Add(this.iconits7);
			this.Controls.Add(this.iconits6);
			this.Controls.Add(this.iconits5);
			this.Controls.Add(this.iconits4);
			this.Controls.Add(this.iconits3);
			this.Controls.Add(this.iconits2);
			this.Controls.Add(this.iconits1);
			this.Name = "Form1";
			this.Text = "Iconits";
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
	}
}
