using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CopyFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            copyFolder("c:\\1", "d:", "test");
        }
        
        /// <summary>
        /// This method copy a folder with name 'nameFolder' in path 'sourcePath' to path 'goalPath'
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="goalPath"></param>
        /// <param name="nameFolder"></param>
        public void copyFolder(string sourcePath, string goalPath, 
                                 string nameFolder)
        {
            System.IO.Directory.CreateDirectory(goalPath + "\\" + nameFolder);
            string[] nameSubDir = System.IO.Directory.GetDirectories(sourcePath +"\\"+ nameFolder);
            if (nameSubDir.Length != 0)
            {
                foreach (string var in nameSubDir)
                {
                    string str = var.Replace(sourcePath + "\\" + nameFolder+"\\", "");
                    copyFolder(sourcePath + "\\" + nameFolder, goalPath + "\\" + nameFolder, str);
                }
            }
            string[] nameSubFile = System.IO.Directory.GetFiles(sourcePath + "\\" + nameFolder);
            foreach (string sFile in nameSubFile)
            {
                string gFile = sFile.Replace(sourcePath, goalPath);
                System.IO.File.Copy(sFile, gFile, true);
             }
        }
    }
}