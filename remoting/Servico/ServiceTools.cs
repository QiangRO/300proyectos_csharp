using System;
using System.Diagnostics;

namespace Servico
{
	/// <summary>
	/// Summary description for ServiceTools.
	/// </summary>
	public  class ServiceTools
	{
		public  ServiceTools()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static void EventMsg(string Mensagem, EventLogEntryType Tipo)
		{
			EventLog evento = new EventLog("Aplicativo Distribuído");
			evento.Log = "Application";
			evento.Source = "Processamento de imagens distribuída";
			evento.WriteEntry(Mensagem, Tipo);
			evento.Close();
		}

	}
}

