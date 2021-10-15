using System;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Sentinel
{
	/// <summary>
	/// Servidor remote
	/// </summary>
	class RemoteServer
	{
		/// <summary>
		/// O server age como container para a lib remotelib e responde as requisicoes do cliente
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{			
			//esta sendo utilizado um http channel
			//8228 eh o numero da porta que estamos utilizando para rodar o servico
			TcpServerChannel remObj = new TcpServerChannel(8220);
			//bind no channel para chamada do sistema operacional
			ChannelServices.RegisterChannel(remObj);
			//Aqui estamos dizendo ao servidor o que fazer quando ele pegar uma requisicao do cliente
			RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteLib), 
				"RemoteLib", WellKnownObjectMode.Singleton);			
			Console.WriteLine("Aguardando instrucoes do servidor");
			Console.ReadLine();
		}
	}
}
