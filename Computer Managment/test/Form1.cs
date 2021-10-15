using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using Microsoft.Win32;  
using System.Drawing.Drawing2D;
using System.ComponentModel.Design  ;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Drawing.Printing;

namespace test
{
    public partial class Form1 : Form
    {
        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000001,
            SHERB_NOSOUND = 0x00000004
        }

        public Form1()
        {



            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint result = SHEmptyRecycleBin(IntPtr.Zero, null, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "نام کامپیوتر شما '" + Environment.MachineName + "' است"; 

        }

        public void CopyFile(string FileSource, string FileDestination)
        {

        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath,
        RecycleFlags dwFlags);

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/s");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/r");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/l");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
        }
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString(string lpstrCommand,
        StringBuilder lpstrReturnString,
        int uReturnLength,
        IntPtr hwndCallback);

        private void button6_Click(object sender, EventArgs e)
        {
            int ret = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            uint result = SHEmptyRecycleBin(IntPtr.Zero, null, 0);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult Result ;
           Result =  MessageBox.Show("قصد خروج دارید؟","خروج",MessageBoxButtons.YesNo) ;
           if (Result == DialogResult.Yes)
               this.Close(); 
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            int ret = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rasdial", "/disconnect");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", textBox1.Text.Trim () );

        }

        private void button10_Click(object sender, EventArgs e)
        {
            GetInstalledPrinters();

        }
        private void GetInstalledPrinters()
        {
            foreach (string printerName in PrinterSettings.InstalledPrinters)
                listBox1.Items.Add(printerName);
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {          
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            RegistryKey user = Registry.CurrentUser;
            RegistryKey change = user.OpenSubKey("Software", true).OpenSubKey("Microsoft", true).OpenSubKey("Internet Explorer", true).OpenSubKey("Main", true);
            change.SetValue("Start Page", textBox2.Text.ToString () );

         
            MessageBox.Show("'" + textBox2.Text + "' صفحه خانگي شما شد.","تاييد"); 
        }



    }
}