using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.Win32;
using System.Security;
using System.Security.Permissions;
using System.IO;
// Copyright Decebal Mihailescu 2005
// You can include the following code in your product free of charge 
// as long as you include the existing copyright notice
//[assembly:RegistryPermissionAttribute(RegistryPermissionAccess.AllAccess)]


namespace AppendMenu
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	[RegistryPermissionAttribute(SecurityAction.Demand, Unrestricted=true)]
	public class AppendToMenu : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog openFileDialogSelectExe;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonSelect;
		private System.Windows.Forms.Button btnAddMenu;
		private System.Windows.Forms.Button btnRemoveMenu;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAbout;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AppendToMenu()
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
			this.openFileDialogSelectExe = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonSelect = new System.Windows.Forms.Button();
			this.btnAddMenu = new System.Windows.Forms.Button();
			this.btnRemoveMenu = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// openFileDialogSelectExe
			// 
			this.openFileDialogSelectExe.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogSelectExe_FileOk);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Name in the context menu:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(200, 16);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(328, 20);
			this.txtName.TabIndex = 1;
			this.txtName.Text = "";
			this.txtName.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(200, 56);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(288, 20);
			this.txtPath.TabIndex = 2;
			this.txtPath.Text = "";
			this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(192, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "&Path to the executable or command:";
			// 
			// buttonSelect
			// 
			this.buttonSelect.Location = new System.Drawing.Point(488, 56);
			this.buttonSelect.Name = "buttonSelect";
			this.buttonSelect.Size = new System.Drawing.Size(40, 20);
			this.buttonSelect.TabIndex = 3;
			this.buttonSelect.Text = "...";
			this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
			// 
			// btnAddMenu
			// 
			this.btnAddMenu.Location = new System.Drawing.Point(29, 96);
			this.btnAddMenu.Name = "btnAddMenu";
			this.btnAddMenu.Size = new System.Drawing.Size(96, 20);
			this.btnAddMenu.TabIndex = 4;
			this.btnAddMenu.Text = "&Add Menu";
			this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
			// 
			// btnRemoveMenu
			// 
			this.btnRemoveMenu.Location = new System.Drawing.Point(159, 96);
			this.btnRemoveMenu.Name = "btnRemoveMenu";
			this.btnRemoveMenu.Size = new System.Drawing.Size(96, 20);
			this.btnRemoveMenu.TabIndex = 5;
			this.btnRemoveMenu.Text = "&Remove Menu";
			this.btnRemoveMenu.Click += new System.EventHandler(this.btnRemoveMenu_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnExit.Location = new System.Drawing.Point(419, 96);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(96, 20);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "E&xit";
			this.btnExit.Click += new System.EventHandler(this.buttonSelect_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAbout.Location = new System.Drawing.Point(289, 96);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(96, 20);
			this.btnAbout.TabIndex = 6;
			this.btnAbout.Text = "Ab&out";
			this.btnAbout.Click += new System.EventHandler(this.button1_Click);
			// 
			// AppendToMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(544, 134);
			this.Controls.Add(this.btnAddMenu);
			this.Controls.Add(this.buttonSelect);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRemoveMenu);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnAbout);
			this.Name = "AppendToMenu";
			this.Text = "Add Frequently used option to the context Menu";
			this.Load += new System.EventHandler(this.AppendToMenu_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new AppendToMenu());
		}

		private void openFileDialogSelectExe_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
		
		}

		private void buttonSelect_Click(object sender, System.EventArgs e)
		{
			if(sender == this.buttonSelect)
			{
				openFileDialogSelectExe.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
				if(openFileDialogSelectExe.ShowDialog(this) == DialogResult.OK)
				{
					this.txtPath.Text = openFileDialogSelectExe.FileName;
				}
			}
			if(sender == this.btnExit)
			{
				this.Close();
			}
;
		}

		private void btnAddMenu_Click(object sender, System.EventArgs e)
		{
			RegistryKey regmenu = null;
			RegistryKey regcmd = null;
			try
			{
				regmenu = Registry.ClassesRoot.CreateSubKey(MenuName);
				if(regmenu != null)
					regmenu.SetValue("",this.txtName.Text);
				regcmd = Registry.ClassesRoot.CreateSubKey(Command);
				if(regcmd != null)
					 regcmd.SetValue("",this.txtPath.Text);

			}
			catch(Exception ex)
			{
				MessageBox.Show(this,ex.ToString());
			}
			finally	   
			{
				if(regmenu != null)
					regmenu.Close();
				if(regcmd != null)
					regcmd.Close();
			}		
		}

		private void btnRemoveMenu_Click(object sender, System.EventArgs e)
		{
			try
			{
				RegistryKey reg = Registry.ClassesRoot.OpenSubKey(Command);
				if(reg != null)
				{
					reg.Close();
					Registry.ClassesRoot.DeleteSubKey(Command);
				}
				reg = Registry.ClassesRoot.OpenSubKey(MenuName);
				if(reg != null)
				{
					reg.Close();
					Registry.ClassesRoot.DeleteSubKey(MenuName);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(this,ex.ToString());
			}
			finally	   
			{						
			}
	
		}

		private void AppendToMenu_Load(object sender, System.EventArgs e)
		{

			RegistryKey regmenu = null;
			RegistryKey regcmd = null;
			try
			{
				this.CheckSecurity();
				this.btnAddMenu.Enabled = false;				
				regmenu = Registry.ClassesRoot.OpenSubKey(MenuName,false);
				if(regmenu != null)
					this.txtName.Text = (String)regmenu.GetValue("");
				regcmd = Registry.ClassesRoot.OpenSubKey(Command,false);
				if(regcmd != null)
					this.txtPath.Text = (String)regcmd.GetValue("");
				btnRemoveMenu.Enabled = txtName.Text.Length > 0 || this.txtPath.Text.Length > 0;


			}
			catch (ArgumentException ex)
			{
				// RegistryPermissionAccess.AllAccess can not be used as a parameter for GetPathList.
				MessageBox.Show(this,"An ArgumentException occured as a result of using AllAccess.  " 
					+ "AllAccess cannot be used as a parameter in GetPathList because it represents more than one " 
					+ "type of registry variable access : \n" + ex);
			}
			catch (SecurityException ex)
			{
				// RegistryPermissionAccess.AllAccess can not be used as a parameter for GetPathList.
				MessageBox.Show(this,"An ArgumentException occured as a result of using AllAccess.  " + ex);
				this.btnAddMenu.Enabled = false;
				this.btnRemoveMenu.Enabled = false;
			}
			catch(Exception ex)
			{
				MessageBox.Show(this,ex.ToString());
			}
			finally	   
			{
				if(regmenu != null)
					regmenu.Close();
				if(regcmd != null)
					regcmd.Close();
			}
		}

		private const string MenuName = "Folder\\shell\\NewMenuOption";
		public const string Command = "Folder\\shell\\NewMenuOption\\command";


		private void txtPath_TextChanged(object sender, System.EventArgs e)
		{
			if(((TextBox)sender).Text.Length > 0)
			{
				if( sender.Equals(txtPath))
				{
					if(txtPath.Text.IndexOf('\\') >= 0) 
						this.btnAddMenu.Enabled = this.txtName.Text.Length > 0 && File.Exists(txtPath.Text);
					else
						this.btnAddMenu.Enabled = this.txtName.Text.Length > 0;
				}
			}
			else
			{
				this.btnAddMenu.Enabled = false;
			}
			btnRemoveMenu.Enabled = txtName.Text.Length > 0 || this.txtPath.Text.Length > 0;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			About ab = new About();
			ab.ShowDialog(this);
		}

		private void CheckSecurity()
		{
			
			//check registry permissions
			RegistryPermission regPerm;
			regPerm = new RegistryPermission(RegistryPermissionAccess.Write, "HKEY_CLASSES_ROOT\\"+MenuName);
			regPerm.AddPathList(RegistryPermissionAccess.Write, "HKEY_CLASSES_ROOT\\"+Command);
			regPerm.Demand();
			
		}
	}
}
