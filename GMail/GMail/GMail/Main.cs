using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using System.Net.Mail;
using GmailAPI;

namespace GMail
{
    public partial class Main : Form
    {
        private bool _browserReady = false;
        string username, password ;
        string attachfilepatch;
        MailMessage MyMessage;
        public Main()
        {
            InitializeComponent();
        }

        private void WaitUntilBrowserReady()
        {
            if (this._browserReady)
            {
                return;
            }
            for (int i = 0; i < 60 && !this._browserReady; i++)
            {
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
            username = Properties.Settings.Default.Username;
            password = Properties.Settings.Default.PassWord;
        }

        private void lklAttach_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                attachfilepatch = openFileDialog1.FileName;
                FileInfo file = new FileInfo(attachfilepatch);
                lklAttach.Text = file.Name + " " + (file.Length / 1024).ToString("N0") + " KB";
            }
        }
     
        private void send()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                SmtpClient MySMTPClient = new SmtpClient("smtp.gmail.com", 25);
                MySMTPClient.EnableSsl = true;
                NetworkCredential MyCredentials = new NetworkCredential(username, password);
                MySMTPClient.Credentials = MyCredentials;
                MyMessage = new MailMessage(username + "@gmail.com", txtTo.Text, txtSubject.Text,htmlTextbox1.Text );
                MyMessage.IsBodyHtml = true;
                if (attachfilepatch != null)
                {
                    MyMessage.Attachments.Add(new Attachment(attachfilepatch));
                    MySMTPClient.Send(MyMessage);
                }
                else
                    MySMTPClient.Send(MyMessage);
                MessageBox.Show("           Message sent ...            ",
                    "Sent",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception MyError)
            {
                MessageBox.Show("An error has occurred: " + MyError.Message);
            }
        }
        private void btnSendTop_Click(object sender, EventArgs e)
        {
            send();
        }

        private void btnSendButton_Click(object sender, EventArgs e)
        {
            btnSendTop_Click(sender, e);
        }

        private void btnSendButton_Click_1(object sender, EventArgs e)
        {
            send();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(GmailAdapter.GMAIL_HOST_URL + "/gmail");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
