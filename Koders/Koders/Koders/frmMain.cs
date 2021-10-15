using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace Koders
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		#region Private Variables
		private string _projectsDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Visual Studio 2008\Projects";
		private Process _process = null;
		private BindingList<SearchResult> _results = new BindingList<SearchResult>();
		private	string _path;
		private string _stringToFind;
		private string _filter;
		#endregion

		#region Properties
		public string Status
		{
			get { return this.statusLabel.Text; }
			set { this.statusLabel.Text = value; }
		}
	
		#endregion

		#region Find in Files
		private void FindInFiles(string path, string stringToFind)
		{
			if (Directory.Exists(path))
			{
				if (!string.IsNullOrEmpty(stringToFind))
				{
					this.toolStripProgressBar1.Visible = true;
					this.toolStripProgressBar1.Value = this.toolStripProgressBar1.Minimum;
					this.findInFilesButton.Enabled = false;
					this.stopButton.Enabled = true;
					this.statusLabel.Text = String.Empty;
					this.progressTimer.Start();
					this.Cursor = Cursors.AppStarting;
					_results.Clear();
                    this.SearchResultBindingSource.DataSource = _results;
					_path = path;
					_stringToFind = stringToFind;
					this.backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					this.toolTip1.Show("Please provide a search string.", this.findTextBox.TextBox, 10, this.findTextBox.Height - 4);
				}
			}
			else
			{
				this.toolTip1.Show("Please provide a path to an existing directory.", this.pathTextBox.TextBox, this.pathTextBox.Width - 10, this.pathTextBox.Height - 4);
			}
		}

		private BindingList<SearchResult> FindInFiles()
		{
			_process = new Process();
			_process.StartInfo.FileName = "findstr.exe";
			_process.StartInfo.CreateNoWindow = true;
			_process.StartInfo.UseShellExecute = false;
			_process.StartInfo.WorkingDirectory = _path;
			_process.StartInfo.RedirectStandardError = true;
			_process.StartInfo.RedirectStandardOutput = true;
			_process.StartInfo.Arguments = "/S /P /N /I /C:\"" + _stringToFind + "\" " + _filter;
			_process.Start();
			bool done = false;
			SearchResult sr;
			BindingList<SearchResult> bls = new BindingList<SearchResult>();
			string line;
			while (!done)
			{
				if (_process.HasExited)
				{
					done = true;
				}

				int progressChunk = 0;
				while (_process.StandardOutput.Peek() > 0)
				{
					try
					{
						line = _process.StandardOutput.ReadLine();
						sr = new SearchResult(_path, line);
						this.backgroundWorker1.ReportProgress(0, sr);
						progressChunk++;
						if (progressChunk > 10)
						{
							progressChunk = 0;
						}

						bls.Add(sr);
					}
					catch (ArgumentException ex)
					{
						Debug.WriteLine(ex.Message);
					}
				}

				while (_process.StandardError.Peek() > 0)
				{
					Debug.WriteLine(_process.StandardError.ReadLine());
				}

				if (!done)
				{
					_process.WaitForExit(500);
				}
			}

			_process.WaitForExit();
			_process = null;
			return bls;
		}
		#endregion

        private void findInFilesButton_Click(object sender, EventArgs e)
		{
			FindInFiles(this.pathTextBox.Text, this.findTextBox.Text);
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			this.pathTextBox.Text = _projectsDir;
			this.Status = string.Empty;
			foreach (ToolStripMenuItem item in this.toolStripDropDownButton1.DropDownItems)
			{
				if (item.Checked)
				{
					_filter = (item.Tag as string);
					this.toolStripDropDownButton1.Text = item.Text;
				}
			}
		}

		private void openFolderButton_Click(object sender, EventArgs e)
		{
			this.folderBrowserDialog1.SelectedPath = this.pathTextBox.Text;
			if (DialogResult.OK == this.folderBrowserDialog1.ShowDialog())
			{
				this.pathTextBox.Text = this.folderBrowserDialog1.SelectedPath;
			}
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			DataGridView dgv = (sender as DataGridView);
			if ((e.RowIndex >= 0) && ("Path" == dgv.Columns[e.ColumnIndex].DataPropertyName))
			{
				string	path = (e.Value as string);
				dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = path;
				e.Value = "[..]" + path.Replace(this.pathTextBox.Text, string.Empty);
			}
		}

		private void progressTimer_Tick(object sender, EventArgs e)
		{
			this.progressTimer.Interval = (this.progressTimer.Interval * 2);
			if ((this.toolStripProgressBar1.Value + this.toolStripProgressBar1.Step) > this.toolStripProgressBar1.Maximum)
			{
				this.toolStripProgressBar1.Value = this.toolStripProgressBar1.Minimum;
			}
			else
			{
				this.toolStripProgressBar1.Value += this.toolStripProgressBar1.Step;
			}
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
			FindInFiles();
		}

		private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			SearchResult sr = e.UserState as SearchResult;
			_results.Add(sr);
			UpdateStatusLabel();
		}

		private void UpdateStatusLabel()
		{
			this.statusLabel.Text = String.Format("{0} Matches Found", _results.Count);
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.stopButton.Enabled = false;
			this.findInFilesButton.Enabled = true;
			UpdateStatusLabel();
			this.toolStripProgressBar1.Visible = false;
			this.Cursor = Cursors.Default;
			this.UseWaitCursor = false;
			this.progressTimer.Stop();
			this.progressTimer.Interval = 1000;
		}

		private void stopButton_Click(object sender, EventArgs e)
		{
			_process.Kill();
		}

		private void toolStripDropDownButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			ToolStripDropDownButton parent = (sender as ToolStripDropDownButton);
			if (null != parent)
			{
				foreach (ToolStripMenuItem child in parent.DropDownItems)
				{
					if (e.ClickedItem != child)
					{
						child.Checked = false;
					}
					else
					{
						_filter = child.Tag as string;
						this.toolStripDropDownButton1.Text = child.Text;
					}
				}
			}
		}

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Process.Start(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
        }
	}
}