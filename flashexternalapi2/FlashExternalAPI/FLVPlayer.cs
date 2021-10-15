using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Xml;
using AxShockwaveFlashObjects;

namespace Vml.FLVPlayer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FLVPlayer : System.Windows.Forms.Form
	{
        private StatusBar statusbar;
        private StatusBarPanel fileNameStatusBarPanel;
		private System.Windows.Forms.Panel videoPlaceholder;
		private System.Windows.Forms.Button openVideo;
		private System.Windows.Forms.OpenFileDialog openVideoDialog;
		private AxShockwaveFlashObjects.AxShockwaveFlash flashPlayer;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FLVPlayer()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            try
            {
                flashPlayer.LoadMovie(0, Application.StartupPath + "\\player.swf");
				flashPlayer.FlashCall += new _IShockwaveFlashEvents_FlashCallEventHandler(flashPlayer_FlashCall);
            }
            catch(Exception ex)
            {
                ExceptionUtilities.DisplayException("Unable to load SWF video player, please verify you have Flash Player 8 installed and try again.");
                this.Dispose();
            }
		}

        public FLVPlayer(string moviePath):this()
        {
            this.LoadVideo(moviePath);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FLVPlayer));
			this.openVideo = new System.Windows.Forms.Button();
			this.openVideoDialog = new System.Windows.Forms.OpenFileDialog();
			this.statusbar = new System.Windows.Forms.StatusBar();
			this.fileNameStatusBarPanel = new System.Windows.Forms.StatusBarPanel();
			this.videoPlaceholder = new System.Windows.Forms.Panel();
			this.flashPlayer = new AxShockwaveFlashObjects.AxShockwaveFlash();
			((System.ComponentModel.ISupportInitialize)(this.fileNameStatusBarPanel)).BeginInit();
			this.videoPlaceholder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flashPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// openVideo
			// 
			this.openVideo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.openVideo.Location = new System.Drawing.Point(8, 272);
			this.openVideo.Name = "openVideo";
			this.openVideo.Size = new System.Drawing.Size(88, 23);
			this.openVideo.TabIndex = 1;
			this.openVideo.Text = "Open...";
			this.openVideo.Click += new System.EventHandler(this.openVideo_Click);
			// 
			// statusbar
			// 
			this.statusbar.Location = new System.Drawing.Point(0, 298);
			this.statusbar.Name = "statusbar";
			this.statusbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						 this.fileNameStatusBarPanel});
			this.statusbar.ShowPanels = true;
			this.statusbar.Size = new System.Drawing.Size(338, 22);
			this.statusbar.SizingGrip = false;
			this.statusbar.TabIndex = 4;
			// 
			// fileNameStatusBarPanel
			// 
			this.fileNameStatusBarPanel.Text = "File not loaded";
			this.fileNameStatusBarPanel.ToolTipText = "The file currently loaded";
			this.fileNameStatusBarPanel.Width = 810;
			// 
			// videoPlaceholder
			// 
			this.videoPlaceholder.BackColor = System.Drawing.Color.Black;
			this.videoPlaceholder.Controls.Add(this.flashPlayer);
			this.videoPlaceholder.Location = new System.Drawing.Point(8, 8);
			this.videoPlaceholder.Name = "videoPlaceholder";
			this.videoPlaceholder.Size = new System.Drawing.Size(320, 240);
			this.videoPlaceholder.TabIndex = 6;
			// 
			// flashPlayer
			// 
			this.flashPlayer.ContainingControl = this;
			this.flashPlayer.Enabled = true;
			this.flashPlayer.Location = new System.Drawing.Point(0, 0);
			this.flashPlayer.Name = "flashPlayer";
			this.flashPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flashPlayer.OcxState")));
			this.flashPlayer.Size = new System.Drawing.Size(40, 24);
			this.flashPlayer.TabIndex = 0;
			// 
			// FLVPlayer
			// 
			this.AccessibleName = "FLVPlayer";
			this.AllowDrop = true;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(338, 320);
			this.Controls.Add(this.statusbar);
			this.Controls.Add(this.openVideo);
			this.Controls.Add(this.videoPlaceholder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FLVPlayer";
			this.Text = "FLVPlayer";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FLVPlayer_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FLVPlayer_DragEnter);
			((System.ComponentModel.ISupportInitialize)(this.fileNameStatusBarPanel)).EndInit();
			this.videoPlaceholder.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flashPlayer)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

        private void openVideo_Click(object sender, System.EventArgs e)
        {
            openVideoDialog = new OpenFileDialog();
            openVideoDialog.Filter = "*.flv|*.flv";
            openVideoDialog.Title = "Select a Flash Video file...";
            openVideoDialog.Multiselect = false;
            openVideoDialog.RestoreDirectory = true;

            if(openVideoDialog.ShowDialog() == DialogResult.OK)
            {
                LoadVideo(openVideoDialog.FileName);
            }
        }

        private void LoadVideo(string videoPath)
        {
            fileNameStatusBarPanel.Text = videoPath;
			flashPlayer.CallFunction("<invoke name=\"loadAndPlayVideo\" returntype=\"xml\"><arguments><string>" + videoPath + "</string></arguments></invoke>");
        }

        private void FLVPlayer_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if(fileNameStatusBarPanel.Text != files[0])
            {
                LoadVideo(files[0]);
            }
        }

        private void FLVPlayer_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

//        private void btnUrl_Click(object sender, System.EventArgs e)
//        {
//            UrlDialog urlForm = new UrlDialog();
//
//            if(urlForm.ShowDialog(this) == DialogResult.OK)
//            {
//                if(urlForm.Url != null && urlForm.Url.Length > 0)
//                {
//                    LoadVideo(urlForm.Url);
//                }
//            }
//        }

		public void ResizePlayer(int width, int height)
		{
			flashPlayer.Width = width;
			flashPlayer.Height = height;
			videoPlaceholder.Width = width;
			videoPlaceholder.Height = height;	
		}

		private void flashPlayer_FlashCall(object sender, _IShockwaveFlashEvents_FlashCallEvent e)
		{
			XmlDocument document = new XmlDocument();
			document.LoadXml(e.request);
			
			// Since I have only one call back I just grab the arguments and call
			// the function.  This needs to be made much more flexible when there are
			// multiple call backs going back and forth
			XmlNodeList list = document.GetElementsByTagName("arguments");
			ResizePlayer(Convert.ToInt32(list[0].FirstChild.InnerText), Convert.ToInt32(list[0].ChildNodes[1].InnerText));
		}
	}
}
