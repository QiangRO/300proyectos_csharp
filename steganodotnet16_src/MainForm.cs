using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SteganoZip
{
	public partial class MainForm : Form
	{
		private bool hasNewFiles;

		public MainForm()
		{
			InitializeComponent();
		}

		private void UnZipFiles(string destinationDirectoryName)
		{
			ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = new ICSharpCode.SharpZipLib.Zip.ZipFile(txtZipFileName.Text);

			if (chkDecrypt.Checked)
			{	//decrypt zip file
				zipFile.Password = txtOpenPassword.Text;
			}

			foreach (ListViewItem viewItem in lvAll.SelectedItems)
			{
				ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = viewItem.Tag as ICSharpCode.SharpZipLib.Zip.ZipEntry;
				if (zipEntry != null)
				{
					Stream inputStream = zipFile.GetInputStream(zipEntry);
					FileStream fileStream = new FileStream(
						Path.Combine(destinationDirectoryName, zipEntry.Name),
						FileMode.Create);
					CopyStream(inputStream, fileStream);
					fileStream.Close();
					inputStream.Close();
				}
			}

			zipFile.Close();
		}

		private void ZipFiles(string destinationFileName, string password)
		{
			FileStream outputFileStream = new FileStream(destinationFileName, FileMode.Create);
			ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipStream = new ICSharpCode.SharpZipLib.Zip.ZipOutputStream(outputFileStream);
			ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = null;

			if (txtZipFileName.Text.Length > 0)
			{	//there may be files to copy from annother archive
				zipFile = new ICSharpCode.SharpZipLib.Zip.ZipFile(txtZipFileName.Text);
				if (txtOpenPassword.Text.Length > 0)
				{
					zipFile.Password = txtOpenPassword.Text;
				}
			}

			bool isCrypted = false;
			if (password != null && password.Length > 0)
			{	//encrypt the zip file, if password != null
				zipStream.Password = password;
				isCrypted = true;
			}

			foreach (ListViewItem viewItem in lvAll.Items)
			{
				ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = viewItem.Tag as ICSharpCode.SharpZipLib.Zip.ZipEntry;
				Stream inputStream;
				if (zipEntry == null)
				{
					inputStream = new FileStream(viewItem.Text, FileMode.Open);
					zipEntry = new ICSharpCode.SharpZipLib.Zip.ZipEntry(Path.GetFileName(viewItem.Text));
				}
				else
				{
					inputStream = zipFile.GetInputStream(zipEntry);
				}
				zipEntry.IsVisible = viewItem.Checked;
				zipEntry.IsCrypted = isCrypted;
				zipEntry.CompressionMethod = ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated;
				zipStream.PutNextEntry(zipEntry);
				CopyStream(inputStream, zipStream);
				inputStream.Close();
				zipStream.CloseEntry();
			}

			if (zipFile != null)
			{
				zipFile.Close();
			}

			zipStream.Finish();
			zipStream.Close();
		}

		private void CopyStream(Stream source, Stream destination)
		{
			byte[] buffer = new byte[4096];
			int countBytesRead;
			while ((countBytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
			{
				destination.Write(buffer, 0, countBytesRead);
			}
		}

		private String GetFileName(String filter)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = filter;
			dlg.RestoreDirectory = true;
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				return dlg.FileName;
			}
			else
			{
				return null;
			}
		}

		private void AddListViewItem(ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry, ListView listView)
		{
			ListViewItem viewItem = new ListViewItem(zipEntry.Name);
			viewItem.SubItems.Add(zipEntry.CompressedSize.ToString());
			viewItem.Checked = zipEntry.IsVisible;
			viewItem.Tag = zipEntry;
			listView.Items.Add(viewItem);
		}

		private void ExtractSelectedFiles()
		{
			FolderBrowserDialog dlg = new FolderBrowserDialog();
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				UnZipFiles(dlg.SelectedPath);
			}
		}

		private void Open()
		{
			this.HasNewFiles = false;
			lvAll.Items.Clear();
			lvVisible.Items.Clear();

			if (txtZipFileName.Text.Length > 0)
			{
				ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry;
				ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = new ICSharpCode.SharpZipLib.Zip.ZipFile(txtZipFileName.Text);
				
				if (chkDecrypt.Checked)
				{	//decrypt zip file
					zipFile.Password = txtOpenPassword.Text;
				}

				// list visible files
				for (int n = 0; n < zipFile.Size; n++)
				{
					zipEntry = zipFile[n];
					AddListViewItem(zipFile[n], lvVisible);
				}


				// list all files
				zipEntry = zipFile[0];
				AddListViewItem(zipEntry, lvAll);
				int entryIndex = 0;
				while (zipFile.HasSuccessor(zipEntry))
				{
					zipEntry = zipFile.GetAttachedEntry(zipEntry);
					AddListViewItem(zipEntry, lvAll);
					entryIndex++;
				}

				zipFile.Close();
			}
		}

		private void btnSelectFile_Click(object sender, EventArgs e)
		{
			string fileName = GetFileName("Zip-Archive (*.zip)|*.zip");
			if (fileName != null)
			{
				txtZipFileName.Text = fileName;
			}
		}

		private void SelectNewFile_Click(object sender, EventArgs e)
		{
			string fileName = GetFileName(string.Empty);
			if (fileName != null)
			{
				txtNewFileName.Text = fileName;
			}
		}

		private void btnOpenZipFile_Click(object sender, EventArgs e)
		{
			Open();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			ListViewItem viewItem = new ListViewItem(txtNewFileName.Text);
			lvAll.Items.Add(viewItem);
			viewItem.Checked = chkAddVisible.Checked;
			this.HasNewFiles = true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if ( ! lvAll.Items[0].Checked)
			{
				MessageBox.Show("The first file has to be visible, because it's our only anchor in the central directory.");
			}
			else
			{
				SaveFileDialog dlg = new SaveFileDialog();
				dlg.Filter = "Zip-Archive (*.zip)|*.zip";
				dlg.RestoreDirectory = true;
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					ZipFiles(dlg.FileName, (chkEncrypt.Checked ? txtSavePassword.Text : null));
					txtZipFileName.Text = dlg.FileName;
					txtOpenPassword.Text = txtSavePassword.Text;
					chkDecrypt.Checked = chkEncrypt.Checked;
					Open();
				}
			}
		}

		private void lvAll_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (e.Item.Checked)
			{	//add to visible list
				lvVisible.Items.Add(e.Item.Clone() as ListViewItem);
			}
			else
			{
				//remove from visible list
				foreach (ListViewItem viewItem in lvVisible.Items)
				{
					if (viewItem.Text == e.Item.Text)
					{
						lvVisible.Items.Remove(viewItem);
						break;
					}
				}
			}
		}

		private void lvAll_DoubleClick(object sender, EventArgs e)
		{
			ExtractSelectedFiles();
		}

		private void btnExtract_Click(object sender, EventArgs e)
		{
			ExtractSelectedFiles();
		}

		private void lvAll_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				ListViewItem[] deletedItems = new ListViewItem[lvAll.SelectedItems.Count];
				lvAll.SelectedItems.CopyTo(deletedItems, 0);
				foreach (ListViewItem viewItem in deletedItems)
				{
					lvAll.Items.Remove(viewItem);
				}
			}
		}

		private void btnUp_Click(object sender, EventArgs e)
		{
			if (lvAll.SelectedItems.Count > 0)
			{
				ListViewItem selectedItem = lvAll.SelectedItems[0];
				if (selectedItem.Index > 0)
				{
					int index = selectedItem.Index;
					ListViewItem upperItem = lvAll.Items[selectedItem.Index - 1];
					upperItem.Remove();
					lvAll.Items.Insert(index, upperItem);
					selectedItem.Selected = true;
				}
			}
		}

		private void btnDown_Click(object sender, EventArgs e)
		{
			if (lvAll.SelectedItems.Count > 0)
			{
				ListViewItem selectedItem = lvAll.SelectedItems[0];
				if (selectedItem.Index < lvAll.Items.Count - 1)
				{
					int index = selectedItem.Index;
					ListViewItem lowerItem = lvAll.Items[selectedItem.Index + 1];
					lowerItem.Remove();
					lvAll.Items.Insert(index, lowerItem);
					selectedItem.Selected = true;
				}
			}
		}

		private void chkEncrypt_CheckedChanged(object sender, EventArgs e)
		{
			txtSavePassword.Enabled = chkEncrypt.Checked;
		}

		private void chkDecrypt_CheckedChanged(object sender, EventArgs e)
		{
			txtOpenPassword.Enabled = chkDecrypt.Checked;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			this.HasNewFiles = true;
			txtZipFileName.Text = string.Empty;
			lvAll.Items.Clear();
			lvVisible.Items.Clear();
		}

		private bool HasNewFiles
		{	//encryption of new files doesn't work for unknown reasons
			set
			{
				this.hasNewFiles = value;
				chkEncrypt.Enabled = !value;
			}
			get
			{
				return hasNewFiles;
			}
		}
	}
}