using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;

namespace Servico
{
	/// <summary>
	/// Summary description for Installer.
	/// </summary>
	[RunInstaller(true)]
	public class Installer : System.Configuration.Install.Installer
	{
		public System.ServiceProcess.ServiceProcessInstaller ServiceProcessInstaller1;
		public System.ServiceProcess.ServiceInstaller ServiceInstaller1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Installer()
		{
			// This call is required by the Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
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
			this.ServiceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
			this.ServiceInstaller1 = new System.ServiceProcess.ServiceInstaller();
			// 
			// ServiceProcessInstaller1
			// 
			this.ServiceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
			this.ServiceProcessInstaller1.Password = null;
			this.ServiceProcessInstaller1.Username = null;
			this.ServiceProcessInstaller1.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.ServiceProcessInstaller1_AfterInstall);
			// 
			// ServiceInstaller1
			// 
			this.ServiceInstaller1.DisplayName = "Servico Distribuido";
			this.ServiceInstaller1.ServiceName = "Servico";
			this.ServiceInstaller1.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
			this.ServiceInstaller1.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.ServiceInstaller1_AfterInstall);
			// 
			// Installer
			// 
			this.Installers.AddRange(new System.Configuration.Install.Installer[] {
																					  this.ServiceProcessInstaller1,
																					  this.ServiceInstaller1});

		}
		#endregion

		private void ServiceInstaller1_AfterInstall(object sender, System.Configuration.Install.InstallEventArgs e)
		{
		
		}

		private void ServiceProcessInstaller1_AfterInstall(object sender, System.Configuration.Install.InstallEventArgs e)
		{
		
		}
	}
}
