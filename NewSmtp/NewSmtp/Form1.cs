using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Text.RegularExpressions;


namespace NewSmtp
{
    public partial class Form1 : Form
    {

        #region fialds
        MailMessage maill = new MailMessage();
        #endregion
        #region Ctor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region ValidateEmail

        public bool ValidateEmail(string sEmail)
        {
            Regex exp = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            Match m = exp.Match(sEmail);

            if (m.Success && m.Value.Equals(sEmail)) return true;
            else return false;
        }
        #endregion
        #region button1_Click

        private void button1_Click(object sender, EventArgs e)
        {
            string Emaill = String.Empty;
            int test = 1;
            for (int j = 0; j < test; j++)
            {
                if (ValidateEmail(txtto.Text))
                {
                    Emaill = txtto.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Email Not Valid");
                    return;
                }


                SmtpClient SmtpServer = new SmtpClient();
                SmtpServer.Credentials = new System.Net.NetworkCredential(txtuser.Text.Trim(), txtpass.Text.Trim());
                SmtpServer.Host = txthost.Text.Trim();
                SmtpServer.Port = 587;

                SmtpServer.EnableSsl = true;
                maill = new MailMessage();
                String[] addr = Emaill.Split(',');
                try
                {
                    maill.From = new MailAddress(txtfrom.Text.Trim(), txtfrom.Text.Trim(), System.Text.Encoding.UTF8);
                    Byte i;
                    for (i = 0; i < addr.Length; i++)
                        maill.To.Add(addr[i]);
                    maill.Subject = txtsubject.Text.Trim();
                    maill.Body = richTextBox1.Text;
                    maill.Attachments.Add(new Attachment(textBox1.Text.Trim()));
                    maill.ReplyTo = new MailAddress(Emaill);
                    SmtpServer.Send(maill);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace + "\n", ex.Message);
                }
            }
            MessageBox.Show("Mail Hass Been sent to:" + "\n " + maill.ToString());


        }
        #endregion
        #region button2_Click

        private void button2_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Title = "";
                op.CheckFileExists = true;
                op.CheckPathExists = true;
                op.Filter = "";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = op.FileName.Trim();

                }
            }

        } 
        #endregion
        #region button3_Click

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        #endregion

    }
}

