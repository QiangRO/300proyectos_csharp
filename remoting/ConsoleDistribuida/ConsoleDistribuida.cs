using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Sentinel
{
	/// <summary>
	/// Summary description for ConsoleDistribuida.
	/// </summary>
	public class ConsoleDistribuida : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControlImagens;
		private System.Windows.Forms.TabPage tabPageImagemOriginal;
		private System.Windows.Forms.TabPage tabPageImagemFiltrada;
		private System.Windows.Forms.TabPage tabPageBordasImagem;
		private System.Windows.Forms.Button buttonFiltrar;
		private System.Windows.Forms.PictureBox pictureBoxOriginal;
		private System.Windows.Forms.PictureBox pictureBoxFiltrada;
		private System.Windows.Forms.Button buttonBordas;
		private System.Windows.Forms.PictureBox pictureBoxBordas;
		private System.Windows.Forms.Button buttonFiltraDistribuido;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.ProgressBar progressBarTransacao;

		private System.Diagnostics.Process proc =  new System.Diagnostics.Process();
		private System.Windows.Forms.NumericUpDown numericUpDownPixels;
		private System.Windows.Forms.Label labelPixel;
		private System.Windows.Forms.Button buttonBorda;
		private System.Windows.Forms.ProgressBar progressBarBorda;

		RemoteLib remLib;
		private System.Windows.Forms.TabPage tabPageConfigura;
		private System.Windows.Forms.ListView listViewCliente;
		private System.Windows.Forms.Label labelLista;
		private System.Windows.Forms.Label labelIP;
		private System.Windows.Forms.Label labelPorta;
		private System.Windows.Forms.TextBox textBoxIP;
		private System.Windows.Forms.TextBox textBoxPorta;
		private System.Windows.Forms.Button buttonAdicionar;
		private System.Windows.Forms.ColumnHeader columnHeaderIP;
		private System.Windows.Forms.ColumnHeader columnHeaderPorta;
		private System.Windows.Forms.Button buttonRemover;

		public ConsoleDistribuida()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//inicializando o servidor	
			proc.EnableRaisingEvents = false;
			proc.StartInfo.FileName = "C:\\Distribuido\\remoting\\RemoteServ\\bin\\Debug\\RemoteServ.exe";
			proc.StartInfo.WindowStyle = ProcessWindowStyle.Minimized; 
			proc.Start();

			//apos ter terminado o start registra
			ChannelServices.RegisterChannel(new TcpClientChannel());
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

			proc.Kill();

			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ConsoleDistribuida));
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
																													 "1.1.1.1",
																													 "8220"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
																													 "1.1.1.2",
																													 "8220"}, -1);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
																													 "1.1.1.3",
																													 "8220"}, -1);
			this.tabControlImagens = new System.Windows.Forms.TabControl();
			this.tabPageImagemOriginal = new System.Windows.Forms.TabPage();
			this.labelPixel = new System.Windows.Forms.Label();
			this.numericUpDownPixels = new System.Windows.Forms.NumericUpDown();
			this.progressBarTransacao = new System.Windows.Forms.ProgressBar();
			this.buttonFiltraDistribuido = new System.Windows.Forms.Button();
			this.buttonFiltrar = new System.Windows.Forms.Button();
			this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
			this.tabPageImagemFiltrada = new System.Windows.Forms.TabPage();
			this.progressBarBorda = new System.Windows.Forms.ProgressBar();
			this.buttonBorda = new System.Windows.Forms.Button();
			this.buttonBordas = new System.Windows.Forms.Button();
			this.pictureBoxFiltrada = new System.Windows.Forms.PictureBox();
			this.tabPageBordasImagem = new System.Windows.Forms.TabPage();
			this.pictureBoxBordas = new System.Windows.Forms.PictureBox();
			this.tabPageConfigura = new System.Windows.Forms.TabPage();
			this.listViewCliente = new System.Windows.Forms.ListView();
			this.labelLista = new System.Windows.Forms.Label();
			this.labelIP = new System.Windows.Forms.Label();
			this.labelPorta = new System.Windows.Forms.Label();
			this.textBoxIP = new System.Windows.Forms.TextBox();
			this.textBoxPorta = new System.Windows.Forms.TextBox();
			this.buttonAdicionar = new System.Windows.Forms.Button();
			this.columnHeaderIP = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderPorta = new System.Windows.Forms.ColumnHeader();
			this.buttonRemover = new System.Windows.Forms.Button();
			this.tabControlImagens.SuspendLayout();
			this.tabPageImagemOriginal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPixels)).BeginInit();
			this.tabPageImagemFiltrada.SuspendLayout();
			this.tabPageBordasImagem.SuspendLayout();
			this.tabPageConfigura.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlImagens
			// 
			this.tabControlImagens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlImagens.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControlImagens.Controls.Add(this.tabPageImagemOriginal);
			this.tabControlImagens.Controls.Add(this.tabPageImagemFiltrada);
			this.tabControlImagens.Controls.Add(this.tabPageBordasImagem);
			this.tabControlImagens.Controls.Add(this.tabPageConfigura);
			this.tabControlImagens.Location = new System.Drawing.Point(8, 16);
			this.tabControlImagens.Name = "tabControlImagens";
			this.tabControlImagens.SelectedIndex = 0;
			this.tabControlImagens.Size = new System.Drawing.Size(640, 376);
			this.tabControlImagens.TabIndex = 23;
			// 
			// tabPageImagemOriginal
			// 
			this.tabPageImagemOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPageImagemOriginal.Controls.Add(this.labelPixel);
			this.tabPageImagemOriginal.Controls.Add(this.numericUpDownPixels);
			this.tabPageImagemOriginal.Controls.Add(this.progressBarTransacao);
			this.tabPageImagemOriginal.Controls.Add(this.buttonFiltraDistribuido);
			this.tabPageImagemOriginal.Controls.Add(this.buttonFiltrar);
			this.tabPageImagemOriginal.Controls.Add(this.pictureBoxOriginal);
			this.tabPageImagemOriginal.Location = new System.Drawing.Point(4, 25);
			this.tabPageImagemOriginal.Name = "tabPageImagemOriginal";
			this.tabPageImagemOriginal.Size = new System.Drawing.Size(632, 347);
			this.tabPageImagemOriginal.TabIndex = 0;
			this.tabPageImagemOriginal.Text = "Imagem Original";
			// 
			// labelPixel
			// 
			this.labelPixel.Location = new System.Drawing.Point(16, 240);
			this.labelPixel.Name = "labelPixel";
			this.labelPixel.Size = new System.Drawing.Size(104, 16);
			this.labelPixel.TabIndex = 27;
			this.labelPixel.Text = "Pixels a processar:";
			// 
			// numericUpDownPixels
			// 
			this.numericUpDownPixels.Location = new System.Drawing.Point(160, 232);
			this.numericUpDownPixels.Maximum = new System.Decimal(new int[] {
																				200000,
																				0,
																				0,
																				0});
			this.numericUpDownPixels.Name = "numericUpDownPixels";
			this.numericUpDownPixels.Size = new System.Drawing.Size(72, 20);
			this.numericUpDownPixels.TabIndex = 26;
			this.numericUpDownPixels.Value = new System.Decimal(new int[] {
																			  1000,
																			  0,
																			  0,
																			  0});
			// 
			// progressBarTransacao
			// 
			this.progressBarTransacao.Location = new System.Drawing.Point(8, 280);
			this.progressBarTransacao.Name = "progressBarTransacao";
			this.progressBarTransacao.Size = new System.Drawing.Size(616, 16);
			this.progressBarTransacao.TabIndex = 25;
			// 
			// buttonFiltraDistribuido
			// 
			this.buttonFiltraDistribuido.Location = new System.Drawing.Point(336, 240);
			this.buttonFiltraDistribuido.Name = "buttonFiltraDistribuido";
			this.buttonFiltraDistribuido.Size = new System.Drawing.Size(152, 32);
			this.buttonFiltraDistribuido.TabIndex = 24;
			this.buttonFiltraDistribuido.Text = "Distribuido";
			this.buttonFiltraDistribuido.Click += new System.EventHandler(this.buttonFiltraDistribuido_Click);
			// 
			// buttonFiltrar
			// 
			this.buttonFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFiltrar.Location = new System.Drawing.Point(536, 304);
			this.buttonFiltrar.Name = "buttonFiltrar";
			this.buttonFiltrar.Size = new System.Drawing.Size(88, 32);
			this.buttonFiltrar.TabIndex = 23;
			this.buttonFiltrar.Text = "Filtrar";
			this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
			// 
			// pictureBoxOriginal
			// 
			this.pictureBoxOriginal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOriginal.Image")));
			this.pictureBoxOriginal.Location = new System.Drawing.Point(8, 8);
			this.pictureBoxOriginal.Name = "pictureBoxOriginal";
			this.pictureBoxOriginal.Size = new System.Drawing.Size(616, 215);
			this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxOriginal.TabIndex = 22;
			this.pictureBoxOriginal.TabStop = false;
			// 
			// tabPageImagemFiltrada
			// 
			this.tabPageImagemFiltrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPageImagemFiltrada.Controls.Add(this.progressBarBorda);
			this.tabPageImagemFiltrada.Controls.Add(this.buttonBorda);
			this.tabPageImagemFiltrada.Controls.Add(this.buttonBordas);
			this.tabPageImagemFiltrada.Controls.Add(this.pictureBoxFiltrada);
			this.tabPageImagemFiltrada.Location = new System.Drawing.Point(4, 25);
			this.tabPageImagemFiltrada.Name = "tabPageImagemFiltrada";
			this.tabPageImagemFiltrada.Size = new System.Drawing.Size(632, 347);
			this.tabPageImagemFiltrada.TabIndex = 1;
			this.tabPageImagemFiltrada.Text = "Imagem Filtrada";
			// 
			// progressBarBorda
			// 
			this.progressBarBorda.Location = new System.Drawing.Point(7, 272);
			this.progressBarBorda.Name = "progressBarBorda";
			this.progressBarBorda.Size = new System.Drawing.Size(616, 16);
			this.progressBarBorda.TabIndex = 27;
			// 
			// buttonBorda
			// 
			this.buttonBorda.Location = new System.Drawing.Point(335, 232);
			this.buttonBorda.Name = "buttonBorda";
			this.buttonBorda.Size = new System.Drawing.Size(152, 32);
			this.buttonBorda.TabIndex = 26;
			this.buttonBorda.Text = "Distribuido";
			this.buttonBorda.Click += new System.EventHandler(this.buttonBorda_Click);
			// 
			// buttonBordas
			// 
			this.buttonBordas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBordas.Location = new System.Drawing.Point(536, 304);
			this.buttonBordas.Name = "buttonBordas";
			this.buttonBordas.Size = new System.Drawing.Size(88, 32);
			this.buttonBordas.TabIndex = 24;
			this.buttonBordas.Text = "Bordas";
			this.buttonBordas.Click += new System.EventHandler(this.buttonBordas_Click);
			// 
			// pictureBoxFiltrada
			// 
			this.pictureBoxFiltrada.Location = new System.Drawing.Point(8, 8);
			this.pictureBoxFiltrada.Name = "pictureBoxFiltrada";
			this.pictureBoxFiltrada.Size = new System.Drawing.Size(400, 206);
			this.pictureBoxFiltrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxFiltrada.TabIndex = 23;
			this.pictureBoxFiltrada.TabStop = false;
			// 
			// tabPageBordasImagem
			// 
			this.tabPageBordasImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPageBordasImagem.Controls.Add(this.pictureBoxBordas);
			this.tabPageBordasImagem.Location = new System.Drawing.Point(4, 25);
			this.tabPageBordasImagem.Name = "tabPageBordasImagem";
			this.tabPageBordasImagem.Size = new System.Drawing.Size(632, 347);
			this.tabPageBordasImagem.TabIndex = 2;
			this.tabPageBordasImagem.Text = "Bordas da Imagem";
			// 
			// pictureBoxBordas
			// 
			this.pictureBoxBordas.Location = new System.Drawing.Point(8, 8);
			this.pictureBoxBordas.Name = "pictureBoxBordas";
			this.pictureBoxBordas.Size = new System.Drawing.Size(400, 206);
			this.pictureBoxBordas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxBordas.TabIndex = 24;
			this.pictureBoxBordas.TabStop = false;
			// 
			// tabPageConfigura
			// 
			this.tabPageConfigura.Controls.Add(this.buttonRemover);
			this.tabPageConfigura.Controls.Add(this.buttonAdicionar);
			this.tabPageConfigura.Controls.Add(this.textBoxPorta);
			this.tabPageConfigura.Controls.Add(this.textBoxIP);
			this.tabPageConfigura.Controls.Add(this.labelPorta);
			this.tabPageConfigura.Controls.Add(this.labelIP);
			this.tabPageConfigura.Controls.Add(this.labelLista);
			this.tabPageConfigura.Controls.Add(this.listViewCliente);
			this.tabPageConfigura.Location = new System.Drawing.Point(4, 25);
			this.tabPageConfigura.Name = "tabPageConfigura";
			this.tabPageConfigura.Size = new System.Drawing.Size(632, 347);
			this.tabPageConfigura.TabIndex = 3;
			this.tabPageConfigura.Text = "Configurações";
			// 
			// listViewCliente
			// 
			this.listViewCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																							  this.columnHeaderIP,
																							  this.columnHeaderPorta});
			this.listViewCliente.FullRowSelect = true;
			this.listViewCliente.GridLines = true;
			this.listViewCliente.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
																							listViewItem1,
																							listViewItem2,
																							listViewItem3});
			this.listViewCliente.Location = new System.Drawing.Point(216, 26);
			this.listViewCliente.Name = "listViewCliente";
			this.listViewCliente.Size = new System.Drawing.Size(408, 318);
			this.listViewCliente.TabIndex = 0;
			this.listViewCliente.View = System.Windows.Forms.View.Details;
			// 
			// labelLista
			// 
			this.labelLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLista.Location = new System.Drawing.Point(216, 10);
			this.labelLista.Name = "labelLista";
			this.labelLista.Size = new System.Drawing.Size(408, 16);
			this.labelLista.TabIndex = 1;
			this.labelLista.Text = "Lista de clientes a serem utilizados no processamento";
			// 
			// labelIP
			// 
			this.labelIP.Location = new System.Drawing.Point(8, 32);
			this.labelIP.Name = "labelIP";
			this.labelIP.Size = new System.Drawing.Size(32, 16);
			this.labelIP.TabIndex = 2;
			this.labelIP.Text = "IP:";
			// 
			// labelPorta
			// 
			this.labelPorta.Location = new System.Drawing.Point(8, 60);
			this.labelPorta.Name = "labelPorta";
			this.labelPorta.Size = new System.Drawing.Size(40, 16);
			this.labelPorta.TabIndex = 3;
			this.labelPorta.Text = "Porta:";
			// 
			// textBoxIP
			// 
			this.textBoxIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxIP.Location = new System.Drawing.Point(64, 32);
			this.textBoxIP.Name = "textBoxIP";
			this.textBoxIP.Size = new System.Drawing.Size(112, 20);
			this.textBoxIP.TabIndex = 4;
			this.textBoxIP.Text = "1.1.1.1";
			// 
			// textBoxPorta
			// 
			this.textBoxPorta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxPorta.Location = new System.Drawing.Point(64, 60);
			this.textBoxPorta.Name = "textBoxPorta";
			this.textBoxPorta.Size = new System.Drawing.Size(112, 20);
			this.textBoxPorta.TabIndex = 5;
			this.textBoxPorta.Text = "8220";
			// 
			// buttonAdicionar
			// 
			this.buttonAdicionar.Location = new System.Drawing.Point(184, 32);
			this.buttonAdicionar.Name = "buttonAdicionar";
			this.buttonAdicionar.Size = new System.Drawing.Size(24, 24);
			this.buttonAdicionar.TabIndex = 6;
			this.buttonAdicionar.Text = ">";
			this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
			// 
			// columnHeaderIP
			// 
			this.columnHeaderIP.Text = "IP";
			this.columnHeaderIP.Width = 200;
			// 
			// columnHeaderPorta
			// 
			this.columnHeaderPorta.Text = "Porta";
			// 
			// buttonRemover
			// 
			this.buttonRemover.Location = new System.Drawing.Point(184, 60);
			this.buttonRemover.Name = "buttonRemover";
			this.buttonRemover.Size = new System.Drawing.Size(24, 24);
			this.buttonRemover.TabIndex = 7;
			this.buttonRemover.Text = "<";
			this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
			// 
			// ConsoleDistribuida
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 398);
			this.Controls.Add(this.tabControlImagens);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConsoleDistribuida";
			this.Text = "Console Distribuída";
			this.tabControlImagens.ResumeLayout(false);
			this.tabPageImagemOriginal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPixels)).EndInit();
			this.tabPageImagemFiltrada.ResumeLayout(false);
			this.tabPageBordasImagem.ResumeLayout(false);
			this.tabPageConfigura.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ConsoleDistribuida());
		}		

		private void AplicaFiltro()
		{				
			int[] mascFiltro = new int[25] {1, 1, 2, 1, 1, 1, 3, 4, 3, 1, 2, 4, 6, 4, 2, 1, 3, 4, 3, 1, 1, 1, 2, 1, 1};
			double aux1 = 1;
			double aux54 = 54;
			double auxMascFil = 0;

			double red = 0;
            double green = 0;
            double blue = 0;
			int indice = 0;

			auxMascFil = aux1/aux54;			
			
			Bitmap bitmapOriginal = new Bitmap(pictureBoxOriginal.Image); 
			Bitmap bitmapFiltrada = new Bitmap(pictureBoxOriginal.Size.Width-5,pictureBoxOriginal.Size.Height-5); 

			for(int j=0; j < pictureBoxOriginal.Size.Height-5; j++)
			{
				for(int i=0;i < pictureBoxOriginal.Size.Width-5; i++)
				{					
					
					red = 0;
					green = 0;
					blue = 0;
					indice = 0;

					for (int jMasc=0; jMasc < 5; jMasc++)
					{
						for (int iMasc=0; iMasc < 5; iMasc++)
						{							
							
							red = red + (bitmapOriginal.GetPixel(i+iMasc,j+jMasc).R * mascFiltro[indice]);
							green = green + (bitmapOriginal.GetPixel(i+iMasc,j+jMasc).G * mascFiltro[indice]);
							blue = blue + (bitmapOriginal.GetPixel(i+iMasc,j+jMasc).B * mascFiltro[indice]);
							
							indice++;							
						}
					}

					red = (red * auxMascFil);
					green = (green * auxMascFil);
					blue = (blue * auxMascFil);
					
					bitmapFiltrada.SetPixel( i,j,Color.FromArgb(Convert.ToInt32(red),Convert.ToInt32(green),Convert.ToInt32(blue)));					

				}
			}			

			pictureBoxFiltrada.Image = bitmapFiltrada;
			
		}
		
		private void DetectaBordas()
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

			int indice = 0;					
			
			Bitmap bitmapFiltrada = new Bitmap(pictureBoxFiltrada.Image); 
			Bitmap bitmapBordas = new Bitmap(pictureBoxFiltrada.Size.Width-2,pictureBoxFiltrada.Size.Height-2); 

			for(int j=0; j < pictureBoxFiltrada.Size.Height-2; j++)
			{
				for(int i=0;i < pictureBoxFiltrada.Size.Width-2; i++)
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

					indice = 0;

					for (int jMasc=0; jMasc < 3; jMasc++)
					{
						for (int iMasc=0; iMasc < 3; iMasc++)
						{							
							
							redX = redX + (bitmapFiltrada.GetPixel(i+iMasc,j+jMasc).R * bordSobelSx[indice]);
							redY = redY + (bitmapFiltrada.GetPixel(i+iMasc,j+jMasc).R * bordSobelSy[indice]);

							greenX = greenX + (bitmapFiltrada.GetPixel(i+iMasc,j+jMasc).G * bordSobelSx[indice]);														
							greenY = greenY + (bitmapFiltrada.GetPixel(i+iMasc,j+jMasc).G * bordSobelSy[indice]);

							blueX = blueX + (bitmapFiltrada.GetPixel(i+iMasc,j+jMasc).B * bordSobelSx[indice]);
							blueY = blueY + (bitmapFiltrada.GetPixel(i+iMasc,j+jMasc).B * bordSobelSy[indice]);

							indice++;							
							
						}
					}										

					red =  Math.Sqrt((redX * redX) + (redY * redY) );
					green = Math.Sqrt((greenX * greenX) + (greenY * greenY) );
					blue = Math.Sqrt((blueX * blueX) + (blueY * blueY) );
					
					//Verifica a conta de chegada abaixo!!!
					if (red > 255)
					{
						red = 255;
					}
					
					if (green > 255)
					{
						green = 255;
					}

					if (blue > 255)
					{
						blue = 255;
					}

					bitmapBordas.SetPixel( i,j,Color.FromArgb(Convert.ToInt32(red),Convert.ToInt32(green),Convert.ToInt32(blue)));					

				}
			}			

			pictureBoxBordas.Image = bitmapBordas;
			
		}

		private void buttonFiltrar_Click(object sender, System.EventArgs e)
		{	
			Cursor.Current = Cursors.WaitCursor;
			AplicaFiltro();
			Cursor.Current = Cursors.Default;
		}

		private void buttonBordas_Click(object sender, System.EventArgs e)
		{	
			Cursor.Current = Cursors.WaitCursor;
			DetectaBordas();
			Cursor.Current = Cursors.Default;
		}

		private void buttonFiltraDistribuido_Click(object sender, System.EventArgs e)
		{

			RemoteLib[] remClient = new RemoteLib[listViewCliente.Items.Count];

			progressBarTransacao.Minimum = 0;
			progressBarTransacao.Maximum = pictureBoxOriginal.Size.Height;
			progressBarTransacao.Value =0;
			
			byte[,] matrizRed = new byte[pictureBoxOriginal.Size.Height,pictureBoxOriginal.Size.Width]; 			
			byte[,] matrizGreen = new byte[pictureBoxOriginal.Size.Height,pictureBoxOriginal.Size.Width]; 			
			byte[,] matrizBlue = new byte[pictureBoxOriginal.Size.Height,pictureBoxOriginal.Size.Width]; 			

			int[] processId = new int[listViewCliente.Items.Count];
			string[,] vetorFiltrado = new string [pictureBoxOriginal.Size.Height-4,pictureBoxOriginal.Size.Width-4];
			
			if (remLib == null)
			{
				MessageBox.Show("Servidor indisponivel");
				return; 
			}

			remLib.PixelProcessar = Convert.ToInt32(numericUpDownPixels.Value);			
			
			Bitmap bitmapOriginal = new Bitmap(pictureBoxOriginal.Image); 

			for(int i=0; i < pictureBoxOriginal.Size.Height; i++)
			{
				for(int j=0;j < pictureBoxOriginal.Size.Width; j++)
				{	
					matrizRed[i,j] = bitmapOriginal.GetPixel(j,i).R;
					matrizGreen[i,j] = bitmapOriginal.GetPixel(j,i).G;
					matrizBlue[i,j] = bitmapOriginal.GetPixel(j,i).B;
				}
				progressBarTransacao.Value = i;
			}
			
			Cursor.Current = Cursors.WaitCursor;
			remLib.DisponibilizaImagens("filtro",pictureBoxOriginal.Size.Height,pictureBoxOriginal.Size.Width,matrizRed,matrizGreen,matrizBlue);
			
			progressBarTransacao.Value =0;

			
			//apos ter terminado o start registra

			/*
			remClient[0] = (RemoteLib)Activator.GetObject(typeof(RemoteLib
				//), "tcp://192.168.1.10:8228/RemoteLib");
				), "tcp://1.1.1.1:8220/RemoteLib");

			processId[0] = remClient[0].startaClient();

			remClient[1] = (RemoteLib)Activator.GetObject(typeof(RemoteLib
				//), "tcp://192.168.1.10:8228/RemoteLib");
				), "tcp://1.1.1.2:8220/RemoteLib");

			processId[1] = remClient[1].startaClient();
					

			remClient[2] = (RemoteLib)Activator.GetObject(typeof(RemoteLib
				//), "tcp://192.168.1.10:8228/RemoteLib");
				), "tcp://1.1.1.3:8220/RemoteLib");
			
			processId[2] = remClient[2].startaClient();
			*/


			for(int i = 0; i<listViewCliente.Items.Count; i++)
			{
				remClient[i] = (RemoteLib)Activator.GetObject(typeof(RemoteLib
					), "tcp://" + listViewCliente.Items[i].Text + ":" + listViewCliente.Items[i].SubItems[1].Text + "/RemoteLib");

				processId[i] = remClient[i].startaClient();
			}

			
			while(true)
			{
				Application.DoEvents(); 
				System.Threading.Thread.Sleep(10000);
				if (remLib.RetornaFiltrado(ref vetorFiltrado) == "ocioso" &&
					remLib.ClientsAtivos == 0)
				{
					break;
				}

			}
			
			for(int i = 0; i<listViewCliente.Items.Count; i++)
			{
				remClient[i].DerrubaCliente(processId[i]);
			}

			/*
			remClient[0].DerrubaCliente(processId[0]);
			remClient[1].DerrubaCliente(processId[1]);
			remClient[2].DerrubaCliente(processId[2]);
			*/

			Bitmap bitmapFiltrada = new Bitmap(pictureBoxOriginal.Size.Width-5,pictureBoxOriginal.Size.Height-5); 			
			
			string delimStr = ",";
			char [] delimiter = delimStr.ToCharArray();
			string [] split = null; 			
			int red =-1;
			int green =-1;
			int blue =-1;

			for(int i=0; i < pictureBoxOriginal.Size.Height-5; i++)
			{
				for(int j=0;j < pictureBoxOriginal.Size.Width-5; j++)
				{

					try
					{
						split = vetorFiltrado[i,j].Split(delimiter);
					}
					catch(Exception x)
					{
						split[0] = "255";
						split[1] = "255";
						split[2] = "255";
					}
					
					red =-1;
					green =-1;
					blue =-1;

					foreach (string s in split) 
					{	
						if (red==-1)
						{
							red = Convert.ToInt32(s);
						}
						else if (green==-1)
						{
							green = Convert.ToInt32(s);
						}
						else
						{
							blue = Convert.ToInt32(s);
						}
					}

					bitmapFiltrada.SetPixel( j,i,Color.FromArgb(red,green,blue));

				}
			}			

			pictureBoxFiltrada.Image = bitmapFiltrada;			

			Cursor.Current = Cursors.Default;
		}

		private void buttonBorda_Click(object sender, System.EventArgs e)
		{
			
			Cursor.Current = Cursors.WaitCursor;
			
			RemoteLib[] remClient = new RemoteLib[listViewCliente.Items.Count];

			progressBarBorda.Minimum = 0;
			progressBarBorda.Maximum = pictureBoxFiltrada.Size.Height;
			progressBarBorda.Value =0;			

			byte[,] matrizRed = new byte[pictureBoxFiltrada.Size.Height,pictureBoxFiltrada.Size.Width]; 			
			byte[,] matrizGreen = new byte[pictureBoxFiltrada.Size.Height,pictureBoxFiltrada.Size.Width]; 			
			byte[,] matrizBlue = new byte[pictureBoxFiltrada.Size.Height,pictureBoxFiltrada.Size.Width]; 			

			int[] processId = new int[listViewCliente.Items.Count];
			string[,] vetorBordas = new string [pictureBoxFiltrada.Size.Height-2,pictureBoxFiltrada.Size.Width-2];
			
			if (remLib == null)
			{
				MessageBox.Show("Servidor indisponivel");
				return; 
			}			
			
			Bitmap bitmapFiltrada = new Bitmap(pictureBoxFiltrada.Image); 

			for(int i=0; i < pictureBoxFiltrada.Size.Height; i++)
			{
				for(int j=0;j < pictureBoxFiltrada.Size.Width; j++)
				{	
					matrizRed[i,j] = bitmapFiltrada.GetPixel(j,i).R;
					matrizGreen[i,j] = bitmapFiltrada.GetPixel(j,i).G;
					matrizBlue[i,j] = bitmapFiltrada.GetPixel(j,i).B;
				}
				progressBarBorda.Value = i;
			}
			
			
			remLib.DisponibilizaImagens("bordas",pictureBoxFiltrada.Size.Height,pictureBoxFiltrada.Size.Width,matrizRed,matrizGreen,matrizBlue);
			
			progressBarBorda.Value =0;						

			//apos ter terminado o start registra
			//ChannelServices.RegisterChannel(new TcpClientChannel());
			/*
			remClient[0] = (RemoteLib)Activator.GetObject(typeof(RemoteLib
				//), "tcp://192.168.1.10:8228/RemoteLib");
				), "tcp://1.1.1.1:8220/RemoteLib");
			
			processId[0] = remClient[0].startaClient();
			
			remClient[1] = (RemoteLib)Activator.GetObject(typeof(RemoteLib
				//), "tcp://192.168.1.10:8228/RemoteLib");
				), "tcp://1.1.1.2:8220/RemoteLib");
			
			processId[1] = remClient[1].startaClient();			
			
			remClient[2] = (RemoteLib)Activator.GetObject(typeof(RemoteLib
				//), "tcp://192.168.1.10:8228/RemoteLib");
				), "tcp://1.1.1.3:8220/RemoteLib");
			
			processId[2] = remClient[2].startaClient();	
			*/

			for(int i = 0; i<listViewCliente.Items.Count; i++)
			{
				remClient[i] = (RemoteLib)Activator.GetObject(typeof(RemoteLib
					), "tcp://" + listViewCliente.Items[i].Text + ":" + listViewCliente.Items[i].SubItems[1].Text + "/RemoteLib");

				processId[i] = remClient[i].startaClient();
			}
			
			while(true)
			{
				Application.DoEvents(); 
				System.Threading.Thread.Sleep(15000);
				if (remLib.RetornaBordas(ref vetorBordas) == "ocioso")
				{
					break;
				}

			}

			for(int i = 0; i<listViewCliente.Items.Count; i++)
			{
				remClient[i].DerrubaCliente(processId[i]);
			}
			
			/*
			remClient[0].DerrubaCliente(processId[0]);
			remClient[1].DerrubaCliente(processId[1]);
			remClient[2].DerrubaCliente(processId[2]);
			*/
			
			Bitmap bitmapBordas = new Bitmap(pictureBoxFiltrada.Size.Width-3,pictureBoxFiltrada.Size.Height-3);
			
			string delimStr = ",";
			char [] delimiter = delimStr.ToCharArray();
			string [] split = null; 			
			int red =-1;
			int green =-1;
			int blue =-1;

			for(int i=0; i < pictureBoxFiltrada.Size.Height-3; i++)
			{
				for(int j=0;j < pictureBoxFiltrada.Size.Width-3; j++)
				{
					
					try
					{
						split = vetorBordas[i,j].Split(delimiter);
					}
					catch(Exception x)
					{
						split[0] = "255";
						split[1] = "255";
						split[2] = "255";
					}

					red =-1;
					green =-1;
					blue =-1;

					foreach (string s in split) 
					{	
						if (red==-1)
						{
							red = Convert.ToInt32(s);
						}
						else if (green==-1)
						{
							green = Convert.ToInt32(s);
						}
						else
						{
							blue = Convert.ToInt32(s);
						}
					}
					
					if (red > 255)
					{
						red = 255;
					}
					
					if (green > 255)
					{
						green = 255;
					}

					if (blue > 255)
					{
						blue = 255;
					}

					bitmapBordas.SetPixel( j,i,Color.FromArgb(red,green,blue));

				}
			}			

			pictureBoxBordas.Image = bitmapBordas;			

			Cursor.Current = Cursors.Default;

		}

		private void buttonRemover_Click(object sender, System.EventArgs e)
		{
			if(listViewCliente.Items.Count ==0)
			{
				MessageBox.Show("Não existem clientes a serem removidos!","Console",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
			}
			else
			{
				listViewCliente.FocusedItem.Remove(); 
			}

		}

		private void buttonAdicionar_Click(object sender, System.EventArgs e)
		{			

			if(textBoxIP.Text.Trim() =="")
			{
				MessageBox.Show("IP deve ser informado!","Console",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
				textBoxIP.Focus();
				return;
			}

			if(textBoxPorta.Text.Trim() =="")
			{
				MessageBox.Show("Porta deve ser informada!","Console",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
				textBoxPorta.Focus();
				return;
			}

			ListViewItem lvwItem = new ListViewItem();
			lvwItem.Text = textBoxIP.Text;
			lvwItem.SubItems.Add(textBoxPorta.Text);
			listViewCliente.Items.Add(lvwItem); 
 
		}
		

	}
}
