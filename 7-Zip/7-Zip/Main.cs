using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SevenZip;


namespace _7_Zip
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void btnxtractBrowseArchive_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtExtractArchive.Text = openFileDialog1.FileName;
        }

        private void btnExtractBrowseDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtExtractDirectory.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnBrowseOut_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                txtCompressOutput.Text = saveFileDialog1.FileName;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtCompressDirectory.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnCompression_Click(object sender, EventArgs e)
        {
            SevenZipCompressor.SetLibraryPath(Application.StartupPath + "\\7z.dll");
            SevenZipCompressor tmp = new SevenZipCompressor();
            tmp.ArchiveFormat = OutArchiveFormat.SevenZip;
            tmp.CompressionLevel = CompressionLevel.Ultra;
            tmp.CompressDirectory(txtCompressDirectory.Text, txtCompressOutput.Text);
            MessageBox.Show("Compression Finished ...");
        }

        private void btnExtraction_Click(object sender, EventArgs e)
        {
            SevenZipExtractor.SetLibraryPath(Application.StartupPath + "\\7z.dll");
            using (SevenZipExtractor tmp = new SevenZipExtractor(txtExtractArchive.Text))
            {
                tmp.ExtractArchive(txtExtractDirectory.Text);
            }
            MessageBox.Show("Extraction Finished ...");
        }
    }
}
