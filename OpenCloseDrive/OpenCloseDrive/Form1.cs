using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OpenCloseDrive
{
    public partial class Form1 : Form
    {
        #region Fields
        //Why did i put this here?
        String rt = String.Empty;

        /// <summary>
        /// Importing this god forbiden dll
        /// </summary>
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA")]
        public static extern void mciSendStringA(String lpstrCommand, String lpstrReturnString, long uReturnLength, long hwndCallback);


        #endregion
        #region Ctor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region openb_Click
        private void openb_Click(object sender, System.EventArgs e)
        { mciSendStringA("set CDAudio door open", rt, 127, 0); }//i remember, hehe.

        #endregion
        #region closeb_Click
        private void closeb_Click(object sender, System.EventArgs e)
        { mciSendStringA("set CDAudio door closed", rt, 127, 0); }// YODA FOR L

        #endregion
    }
}