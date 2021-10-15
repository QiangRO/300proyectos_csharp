using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Collections;

namespace Sentinel
{
	/// <summary>
	/// Client da aplicacao distribuida
	/// </summary>
	class RemoteClient
	{
		/// <summary>
		/// Reference the RemoteLib and the System.Runtime.Remoting.dll, as mentioned in the RemotLib
		///this is the vocabulary both the server and the client use to speak to each other
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			string[] vetorTrabalho = new string[4];
			string retorno = "";

			RemoteLib remLib;
			ChannelServices.RegisterChannel(new HttpClientChannel());
			remLib = (RemoteLib)Activator.GetObject(typeof(RemoteLib
			), "http://localhost:8228/RemoteLib");
			
			if (remLib == null)
			{ Console.WriteLine("Servidor indisponivel");
				return; }
			
			ArrayList theDrives = remLib.RemoteDrives();
			foreach(string temp in theDrives)
			{
				Console.WriteLine(temp);
			}
			
			string CompName = remLib.ComputerName();
			Console.WriteLine(CompName);
						
			while(true)
			{
				Console.ReadLine();

				retorno = remLib.SolicitaTrabalho(ref vetorTrabalho);

				Console.WriteLine(retorno);

				if( retorno == "TEM SERVICO")
				{
					Console.WriteLine(vetorTrabalho[0]);
					Console.WriteLine(vetorTrabalho[1]);
					Console.WriteLine(vetorTrabalho[2]);
					vetorTrabalho[2] = "10";

					remLib.DevolveTrabalho(vetorTrabalho);
				}
			}

		}

	}
}

