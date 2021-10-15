using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Sentinel
{
	/// <summary>
	/// Summary description for ClientExe.
	/// </summary>
	public class ClientExe : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox textBoxMensagem;
		
		RemoteLib remLib;

		public ClientExe()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			ChannelServices.RegisterChannel(new  TcpClientChannel());
			remLib = (RemoteLib)Activator.GetObject(typeof(RemoteLib
				//), "tcp://192.168.1.10:8228/RemoteLib");
				), "tcp://1.1.1.3:8228/RemoteLib");						

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ClientExe));
			this.textBoxMensagem = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxMensagem
			// 
			this.textBoxMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxMensagem.Location = new System.Drawing.Point(4, 4);
			this.textBoxMensagem.Multiline = true;
			this.textBoxMensagem.Name = "textBoxMensagem";
			this.textBoxMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxMensagem.Size = new System.Drawing.Size(508, 240);
			this.textBoxMensagem.TabIndex = 0;
			this.textBoxMensagem.Text = "";
			// 
			// ClientExe
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(514, 248);
			this.Controls.Add(this.textBoxMensagem);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ClientExe";
			this.Text = "ClientExe";
			this.Load += new System.EventHandler(this.ClientExe_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ClientExe_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ClientExe());
		}

		private void buttonFechar_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
		private void VaiTrabalhar()
		{			
			
			string texto = "";

			if (remLib == null)
			{
				MessageBox.Show("Servidor indisponivel!");
				return; 
			}
			
			Cursor.Current = Cursors.WaitCursor; 			

			while(true)
			{
				Application.DoEvents();

				this.Refresh();				

				int[,] retornoR = null;
				int[,] retornoG = null;
				int[,] retornoB = null;			
				
				

				string status = "";
				texto = "\n" + "Cliente requisitando serviço";
				textBoxMensagem.Text += texto;
				status = remLib.EnviaTrabalho(ref retornoR,ref retornoG,ref retornoB);								

				if (status == "ocioso")
				{
					Cursor.Current = Cursors.Default;
					texto = "\n" + "Cliente ocioso.";
					textBoxMensagem.Text += texto;
					break;
				}
				else if (status == "filtro")
				{
					texto = "\n" + "Cliente aplicando filtro.";
					textBoxMensagem.Text += texto;
					AplicaFiltro(ref retornoR,ref retornoG,ref retornoB);
					texto = "\n" + "Filtro aplicado.";
					textBoxMensagem.Text += texto;

				}
				else if (status == "borda")
				{
					texto = "\n" + "Cliente aplicando bordas.";
					textBoxMensagem.Text += texto;
					AplicaBordas(ref retornoR,ref retornoG,ref retornoB);
					texto = "\n" + "Borda aplicada.";
					textBoxMensagem.Text += texto;
				}
			}
			
			Cursor.Current = Cursors.Default;
			
		}

		private void AplicaBordas(ref int[,] retornoR,ref int[,] retornoG,ref int[,] retornoB)
		{				
			double[] bordSobelSx = new double[9] {-1, 0, 1, -2, 0, 2, -1, 0, 1};
			double[] bordSobelSy = new double[9] {1, 2, 1, 0, 0, 0, -1, -2, -1};

			double redX = 0;
			double redY = 0;

			double greenX = 0;			
			double greenY = 0;

			double blueX = 0;
			double blueY = 0;

			double red = 0;
			double green = 0;
			double blue = 0;

			int[,] vetorRetorno = null;

			vetorRetorno = new int[retornoR.Length/12,4];											
			
			for (int i=0;i< retornoR.Length/12;i++)
			{
				redX = 0;
				redY = 0;
				greenX = 0;										
				greenY = 0;
				blueX = 0;
				blueY = 0;

				red = 0;
				green = 0;
				blue = 0;		

				for (int j=0;j<9;j++)
				{
					redX += (retornoR[i,j] * bordSobelSx[j]);
					redY += (retornoR[i,j] * bordSobelSy[j]);

					greenX += (retornoG[i,j] * bordSobelSx[j]);
					greenY += (retornoG[i,j] * bordSobelSy[j]);

					blueX += (retornoB[i,j] * bordSobelSx[j]);
					blueY += (retornoB[i,j] * bordSobelSy[j]);															
				}												
				
				red =  Math.Sqrt((redX * redX) + (redY * redY) );
				green = Math.Sqrt((greenX * greenX) + (greenY * greenY) );
				blue = Math.Sqrt((blueX * blueX) + (blueY * blueY) );			

				vetorRetorno[i,0] = retornoB[i,9];
				vetorRetorno[i,1] = Convert.ToInt32(red);
				vetorRetorno[i,2] = Convert.ToInt32(green);
				vetorRetorno[i,3] = Convert.ToInt32(blue);				

			}

			remLib.RecebeResultado(vetorRetorno);

		}

		private void AplicaFiltro(ref int[,] retornoR,ref int[,] retornoG,ref int[,] retornoB)
		{				
			int[] mascFiltro = new int[25] {1, 1, 2, 1, 1, 1, 3, 4, 3, 1, 2, 4, 6, 4, 2, 1, 3, 4, 3, 1, 1, 1, 2, 1, 1};
			double aux1 = 1;
			double aux54 = 54;
			double auxMascFil = 0;

			double red = 0;
			double green = 0;
			double blue = 0;
			int[,] vetorRetorno = null;

			vetorRetorno = new int[retornoR.Length/28,4];						

			auxMascFil = aux1/aux54;			
			
			for (int i=0;i< retornoR.Length/28;i++)
			{
				red = 0;
				green = 0;
				blue = 0;				

				for (int j=0;j<25;j++)
				{
					red += (retornoR[i,j] * mascFiltro[j]);
					green += (retornoG[i,j] * mascFiltro[j]);
					blue += (retornoB[i,j] * mascFiltro[j]);
				}								

				red = (red * auxMascFil);
				green = (green * auxMascFil);
				blue = (blue * auxMascFil);												

				vetorRetorno[i,0] = retornoB[i,25];
				vetorRetorno[i,1] = Convert.ToInt32(red);
				vetorRetorno[i,2] = Convert.ToInt32(green);
				vetorRetorno[i,3] = Convert.ToInt32(blue);				

			}

			remLib.RecebeResultado(vetorRetorno);

		}

		private void ClientExe_Load(object sender, System.EventArgs e)
		{
			//VaiTrabalhar();
		}

		private void ClientExe_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			VaiTrabalhar();
		}
	}
}
