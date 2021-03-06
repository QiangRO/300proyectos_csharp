using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsApplication15
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        int error = 0;
        string un,pw;
        RegistryKey key = Registry.LocalMachine.CreateSubKey("software\\barzin");
        Form chang = new change_pass();
        private void button1_Click(object sender, EventArgs e)
        {
            if (error == 4)
            {
                MessageBox.Show("Sorry,You enter 5 incorrect user name or password\nYou can't take this pargram","Master Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Application.Exit();
            }

            if (textBox1.Text == "User name" && textBox2.Text == "Password")
                MessageBox.Show("Please,Enter User name & password", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                if (textBox1.Text.ToLower()==un && textBox2.Text.ToLower()==pw)
                {
                    MessageBox.Show("Wellcom "+un,"Wellcome",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    this.Hide();
                    chang.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    error++;
                    MessageBox.Show("The user name or password is incorrcet.\nIncorrect data: "+error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox2.PasswordChar = '*';
            textBox2.ForeColor = Color.Black;
            textBox2.BackColor = Color.White;
            
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            /*key.SetValue("user", "barzin", RegistryValueKind.String);
            key.SetValue("pass", "parkour", RegistryValueKind.String);*/
            un = key.GetValue("user","barzin").ToString();
            pw = key.GetValue("pass","parkour").ToString();
            pictureBox1.BackgroundImage = Image.FromFile(Environment.CurrentDirectory+ "\\1.png");
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.White;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Focus();
            this.Activate();
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.Focus();
            this.Activate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightSlateGray;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightSlateGray;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }
    }
}