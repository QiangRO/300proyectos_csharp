using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;

namespace Servico
{
	public class ServicoDistribuido : System.ServiceProcess.ServiceBase
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Diagnostics.Process proc =  new System.Diagnostics.Process();		

		public ServicoDistribuido()
		{
			// This call is required by the Windows.Forms Component Designer.
			InitializeComponent();
				
		}

		// The main entry point for the process
		static void Main()
		{
			System.ServiceProcess.ServiceBase[] ServicesToRun;
	
			// More than one user Service may run within the same process. To add
			// another service to this process, change the following line to
			// create a second service object. For example,
			//
			//   ServicesToRun = new System.ServiceProcess.ServiceBase[] {new Service1(), new MySecondUserService()};
			//
			ServicesToRun = new System.ServiceProcess.ServiceBase[] { new ServicoDistribuido() };

			System.ServiceProcess.ServiceBase.Run(ServicesToRun);
		}

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// ServicoDistribuido
			// 
			this.CanPauseAndContinue = true;
			this.ServiceName = "Servico";

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

		/// <summary>
		/// Set things in motion so your service can do its work.
		/// </summary>
		protected override void OnStart(string[] args)
		{			
			ServiceTools.EventMsg("Começou a startar",System.Diagnostics.EventLogEntryType.Information);									
			
			/*
			try
			{												
				proc.EnableRaisingEvents = false;
				StartInfo.UseShellExecute = true;				
				StartInfo.CreateNoWindow = false;
				StartInfo.FileName = "D:\\Meus documentos\\Tiago\\Distribuidos\\trabalho\\remoting\\ClientExe\\bin\\Debug\\ClientExe.exe";				
				StartInfo.WindowStyle = ProcessWindowStyle.Normal; 
				proc.StartInfo = StartInfo;

				if( proc.Start() == false )
				{					
					ServiceTools.EventMsg("Unable to start the process " + StartInfo.FileName,System.Diagnostics.EventLogEntryType.Error);
				}				
				
			}
			catch(Exception e)
			{
				ServiceTools.EventMsg("Erro ao startar o serviço. "+e.Message,System.Diagnostics.EventLogEntryType.Error);
			}
			
			*/
			try
			{												
				proc.EnableRaisingEvents = false;
				proc.StartInfo.UseShellExecute = true;				
				proc.StartInfo.CreateNoWindow = false;				
				proc.StartInfo.FileName = "C:\\Distribuido\\remoting\\RemoteServClient\\bin\\Debug\\RemoteServClient.exe";
				proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal; 				

				if( proc.Start() == false )
				{					
					ServiceTools.EventMsg("Unable to start the process " + proc.StartInfo.FileName,System.Diagnostics.EventLogEntryType.Error);
				}				
				
			}
			catch(Exception e)
			{
				ServiceTools.EventMsg("Erro ao startar o serviço. "+e.Message,System.Diagnostics.EventLogEntryType.Error);
			}
			

			ServiceTools.EventMsg("Terminou de startat " ,System.Diagnostics.EventLogEntryType.Information);
		}
 
		/// <summary>
		/// Stop this service.
		/// </summary>
		protected override void OnStop()
		{
			try
			{
				proc.Kill();
			}
			catch(Exception e)
			{
				ServiceTools.EventMsg("Erro ao startar o finalizar. "+e.Message,System.Diagnostics.EventLogEntryType.Error);
			}
			
			ServiceTools.EventMsg("Finalizou",System.Diagnostics.EventLogEntryType.Information);
		}
		
	}
}
