using System;
using System.Diagnostics;

namespace Sentinel
{
	/// <summary>
	/// Esta lib coleta informacoes do sistema
	/// Esta classe pode ser chamada diretamente do cliente e do servidor
	/// </summary>
	public class RemoteLib : System.MarshalByRefObject
	{
		
		//arrays que contém os pixels da imagem original
		private byte[,] ImgOriginalRed = null;
		private byte[,] ImgOriginalGreen = null;
		private byte[,] ImgOriginalBlue = null;	

		//array que contém a saida da filtragem da imgagem
		private string[,] ImgSaidaFiltro = null;
		
		//arrays que contém os pixels da imagem filtrada
		private byte[,] ImgFiltradaRed = null;
		private byte[,] ImgFiltradaGreen = null;
		private byte[,] ImgFiltradaBlue = null;	

		//array que contém a saida da detecção de bordas da imgagem
		private string[,] ImgSaidaBorda = null;

		//Armezana o status
		//ocioso - quando não tem trabalho
		//filtro - quando tiver imagem para filtrar
		//borda - quando tiver imagem para detcção de bordas
		private string status = "ocioso";
		
		//Indica quantos pixels o client vai processar por requisição
		private int quantidadePixelProcessar = 0;
		
		//indica qual foi o último pixel processado
		private int proximoPixel = 0;

		//armazena o número de colunas do array original
		private int colunas = 0;

		//armazena o número de linhas do array original
		private int linhas = 0;
		
		//Indica quantos clients estão processando
		private int quantidadeClients = 0;

		public RemoteLib()
		{
			
		}
		
		public int PixelProcessar
		{
			get
			{
				return quantidadePixelProcessar;
			}

			set
			{
				quantidadePixelProcessar = value;
			}
		}

		public int ClientsAtivos
		{
			get
			{
				return quantidadeClients;
			}

			set
			{
				quantidadeClients = value;
			}
		}

		public int startaClient()
		{						
			
			System.Diagnostics.Process proc =  new System.Diagnostics.Process();			

			proc.EnableRaisingEvents = false;
			proc.StartInfo.UseShellExecute = true;				
			proc.StartInfo.CreateNoWindow = false;
			proc.StartInfo.FileName = "C:\\Distribuido\\remoting\\ClientExe\\bin\\Debug\\ClientExe.exe";				
			proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal; 			
			proc.Start();	
			
			Console.WriteLine("Startou um client para processamento. Id do client "+proc.Id);						

			return proc.Id;

		}		

		public void DerrubaCliente(int processId)
		{
			
			Console.WriteLine("Vai derrubar o client que processou a imagem. Id do client "+processId);

//			Process currentProcess = Process.GetCurrentProcess();
			
//			currentProcess = System.Diagnostics.Process.GetProcessById(processId);

			Process localById = Process.GetProcessById(processId);
			
			localById.Kill();						

			Console.WriteLine("Derrubou o client que processou a imagem. Id do client "+processId);

		}		
	
		
		public void DisponibilizaImagens(string imagem, int qtdLinhas, int qtdColunas, byte[,] matrizRed, byte[,] matrizGreen, byte[,] matrizBlue)
		{	
			linhas = qtdLinhas;
			colunas = qtdColunas;
			
			proximoPixel = 0;

			if (imagem == "filtro")
			{
				ImgSaidaFiltro = new string[linhas-3,colunas-3];
		
				ImgOriginalRed = (byte[,]) matrizRed.Clone();
				ImgOriginalGreen = (byte[,]) matrizGreen.Clone();
				ImgOriginalBlue = (byte[,]) matrizBlue.Clone();

				status = "filtro";			
			}
			else
			{

				ImgSaidaBorda = new string[linhas-1,colunas-1];

				ImgFiltradaRed = (byte[,]) matrizRed.Clone();
				ImgFiltradaGreen = (byte[,]) matrizGreen.Clone();
				ImgFiltradaBlue = (byte[,]) matrizBlue.Clone();
			
				status = "borda";
			}			

		}				

		public string RetornaFiltrado(ref string[,] vetorFiltrado)
		{
			if (status == "ocioso")
			{							
				vetorFiltrado = (string[,]) ImgSaidaFiltro.Clone();
			}

			Console.WriteLine("Requisitou resultado. Devolveu status "+status+" e clientes ativos "+this.ClientsAtivos);

			return status;
		}

		
		public string RetornaBordas(ref string[,] vetorFiltrado)
		{
			if (status == "ocioso")
			{							
				vetorFiltrado = (string[,]) ImgSaidaBorda.Clone();
			}

			Console.WriteLine("Requisitou resultado. Devolveu status "+status+" e clientes ativos "+this.ClientsAtivos);

			return status;
		}

		public void RecebeResultado(int [,] vetorResultado)
		{
			int linha = 0;
			int coluna = 0;
			double divisao = 0;
			double restoDivisao = 0;						

			if (status == "filtro")
			{									
				
				for (int i=0;i<vetorResultado.Length/4;i++)
				{

					//Encontra a linha do proximo pixel a ser processado na matriz de saída
					divisao = Math.Abs(vetorResultado[i,0]/(colunas-4));

					//Encontra a coluna do proximo pixel a ser processado na matriz de saída
					restoDivisao = vetorResultado[i,0] - ((colunas-4) * divisao) ;

					linha = Convert.ToInt32(divisao);
					coluna = Convert.ToInt32(restoDivisao);					
					
					//Console.WriteLine("posicao - " + vetorResultado[i,0].ToString());

					//Console.WriteLine("linha-" + linha + " coluna-" + coluna + " vetor resultado-" + vetorResultado[i,2].ToString() );

					ImgSaidaFiltro[linha,coluna] = vetorResultado[i,1] + "," + vetorResultado[i,2] + "," + vetorResultado[i,3];										

				}
			}
			else if (status == "borda")
			{
				for (int i=0;i<vetorResultado.Length/4;i++)
				{

					//Encontra a linha do proximo pixel a ser processado na matriz de saída
					divisao = Math.Abs(vetorResultado[i,0]/(colunas-2));

					//Encontra a coluna do proximo pixel a ser processado na matriz de saída
					restoDivisao = vetorResultado[i,0] - ((colunas-2) * divisao) ;

					linha = Convert.ToInt32(divisao);
					coluna = Convert.ToInt32(restoDivisao);

					ImgSaidaBorda[linha,coluna] = vetorResultado[i,1] + "," + vetorResultado[i,2] + "," + vetorResultado[i,3];					

				}
			}
			
			this.ClientsAtivos -= 1;

		}

		//Prepara e envia a matriz para processamento
		public string EnviaTrabalho( ref int[,] retornoR, ref int[,] retornoG, ref int[,] retornoB)
		{					
			int linha = 0;
			int coluna = 0;
			double divisao = 0;
			double restoDivisao = 0;
			int linhaRetorno = 0;
			int colunaRetorno = 0;
			string statusRetorno = "";

			if (status == "ocioso")
			{
				return status;
			}
				
			statusRetorno = status;			

			Console.WriteLine("Proximo pixel a processar "+proximoPixel.ToString() + " clientes ativos " + this.ClientsAtivos);

			if (status == "filtro")
			{					

				//TODO: Conciderar pixels enviados que não retornaram

				//Difine a quantidade de colunas e linhas da matriz de trabalho
				//um retorno para cada cor
				retornoR = new int[this.PixelProcessar,28];
				retornoG = new int[this.PixelProcessar,28];
				retornoB = new int[this.PixelProcessar,28];
				
				//Encontra a linha do proximo pixel a ser processado na matriz de saída
				divisao = Math.Abs(proximoPixel/(colunas-4));
				//Console.WriteLine("ABSOLUTO: " + Math.Abs(proximoPixel/(colunas-4)) + "colunas "+ colunas);

				//Encontra a coluna do proximo pixel a ser processado na matriz de saída
				restoDivisao = proximoPixel - ((colunas-4) * divisao) ;

				linha = Convert.ToInt32(divisao);
				coluna = Convert.ToInt32(restoDivisao);
				
				if (linha > linhas -5 )
				{
					status = "ocioso";
				}					

				//Vare o array de saída tantas vezes quantos pixels devem ser 
				//enviados ao cliente
				for(int i=linha;i < (linhas-4);i++ )
				{
					for(int j=coluna;j < (colunas-4);j++)
					{						
						colunaRetorno = 0;
						//Vare o array de entrada pegando os dados a serem processados
						//por pixel
						for (int l=i;l<(i+ 5) ;l++)
						{
							for(int c=j;c<(j+ 5) ;c++)
							{									

								retornoR[linhaRetorno,colunaRetorno] = Convert.ToInt32(ImgOriginalRed[l,c]);
								retornoG[linhaRetorno,colunaRetorno] = Convert.ToInt32(ImgOriginalGreen[l,c]);
								retornoB[linhaRetorno,colunaRetorno] = Convert.ToInt32(ImgOriginalBlue[l,c]);
								
								colunaRetorno ++;
							}

						}																								

						retornoR[linhaRetorno,colunaRetorno] = proximoPixel ;
						retornoG[linhaRetorno,colunaRetorno] = proximoPixel ;
						retornoB[linhaRetorno,colunaRetorno] = proximoPixel ;

						proximoPixel++;

						linhaRetorno++;
						
						if (linhaRetorno == this.PixelProcessar )
						{
							break;
						}
										
					}		

					coluna = 0;

					if (linhaRetorno == this.PixelProcessar )
					{
						break;
					}

				}	

				//Console.WriteLine(proximoPixel.ToString());				
				//Console.WriteLine("linha " + linha + " linhas "+ linhas + " linhaRetorno "+linhaRetorno+" this.PixelProcessar "+this.PixelProcessar);
					
			}					
			else if (status == "borda")
			{
				//TODO: Conciderar pixels enviados que não retornaram
				
				//Difine a quantidade de colunas e linhas da matriz de trabalho
				//um retorno para cada cor
				retornoR = new int[this.PixelProcessar,12];
				retornoG = new int[this.PixelProcessar,12];
				retornoB = new int[this.PixelProcessar,12];
				
				//Encontra a linha do proximo pixel a ser processado na matriz de saída
				divisao = Math.Abs(proximoPixel/(colunas-2));
				//Console.WriteLine("ABSOLUTO: " + Math.Abs(proximoPixel/(colunas-4)) + "colunas "+ colunas);

				//Encontra a coluna do proximo pixel a ser processado na matriz de saída
				restoDivisao = proximoPixel - ((colunas-2) * divisao) ;

				linha = Convert.ToInt32(divisao);
				coluna = Convert.ToInt32(restoDivisao);
				
				if (linha > linhas -3 )
				{
					status = "ocioso";
				}									
				
				//Console.WriteLine("linha "+linha+" linhas "+linhas);


				//Vare o array de saída tantas vezes quantos pixels devem ser 
				//enviados ao cliente
				for(int i=linha;i < (linhas-2);i++ )
				{
					for(int j=coluna;j < (colunas-2);j++)
					{						
						colunaRetorno = 0;
						//Vare o array de entrada pegando os dados a serem processados
						//por pixel
						for (int l=i;l<(i+ 3) ;l++)
						{
							for(int c=j;c<(j+ 3) ;c++)
							{	
								
								//Console.WriteLine("l "+l+" c "+c+" linha "+linhaRetorno+" coluna "+colunaRetorno);

								retornoR[linhaRetorno,colunaRetorno] = Convert.ToInt32(ImgFiltradaBlue[l,c]);
								retornoG[linhaRetorno,colunaRetorno] = Convert.ToInt32(ImgFiltradaGreen[l,c]);
								retornoB[linhaRetorno,colunaRetorno] = Convert.ToInt32(ImgFiltradaBlue[l,c]);
								
								colunaRetorno ++;
							}

						}																								

						retornoR[linhaRetorno,colunaRetorno] = proximoPixel ;
						retornoG[linhaRetorno,colunaRetorno] = proximoPixel ;
						retornoB[linhaRetorno,colunaRetorno] = proximoPixel ;

						proximoPixel++;

						linhaRetorno++;
						
						if (linhaRetorno == this.PixelProcessar )
						{
							break;
						}
										
					}		

					coluna = 0;

					if (linhaRetorno == this.PixelProcessar )
					{
						break;
					}

				}


			}									
			
			this.ClientsAtivos += 1;

			return statusRetorno;
		}

	}
}
