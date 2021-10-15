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
    public partial class change_pass : Form
    {
        public change_pass()
        {
            InitializeComponent();
        }
        RegistryKey key = Registry.LocalMachine.OpenSubKey("software\\barzin",true);        
       
        private void button1_Click(object sender, EventArgs e)
        {
            string tt1, tt2, tt3;
            tt1 = t1.Text.ToLower();
            tt2 = t2.Text.ToLower();
            tt3 = t3.Text.ToLower();
            if (t1.Text == "" || t2.Text == "" || t3.Text == "")
            {
                MessageBox.Show("Please,Fill all of boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                t1.Focus();
            }
            else
            {
                if (tt1 != key.GetValue("pass", "parkour").ToString())
                {
                    MessageBox.Show("Old Password is incorrect","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    t1.Focus();
                    t1.SelectAll();
                }
                else if (tt2 != tt3)
                {
                    MessageBox.Show("The Passwords do not match\nPlease retype the new password in both boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    t2.Focus();
                    t2.SelectAll();
                }
                else
                {
                    key.SetValue("pass",tt2,RegistryValueKind.String);
                    MessageBox.Show("The new Password is set successfully","Change Password",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tt4,tt5,tt6;
            tt4=t4.Text.ToLower();
            tt5=t5.Text.ToLower();
            tt6 = t6.Text.ToLower();
            if (t4.Text == "" || t5.Text == "" || t6.Text == "")
            {
                MessageBox.Show("Please,Fill all of boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                t4.Focus();
            }
            else
            {
                if (tt4 != key.GetValue("user", "barzin").ToString())
                {
                    MessageBox.Show("Old Username is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    t4.Focus();
                    t4.SelectAll();
                }
                else if (tt5 != tt6)
                {
                    MessageBox.Show("The Usernames do not match\nPlease retype the new Username in both boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    t5.Focus();
                    t5.SelectAll();
                }
                else
                {
                    key.SetValue("user", tt5, RegistryValueKind.String);
                    MessageBox.Show("The new Username is set successfully", "Change User name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }

        private void t1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void t2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void t3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void t4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void t5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void t6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void t4_Enter(object sender, EventArgs e)
        {
            t4.BackColor = Color.White;
        }

        private void t5_Enter(object sender, EventArgs e)
        {
            t5.BackColor = Color.White;
        }

        private void t6_Enter(object sender, EventArgs e)
        {
            t6.BackColor = Color.White;
        }

        private void t1_Enter(object sender, EventArgs e)
        {
            t1.BackColor = Color.White;
        }

        private void t2_Enter(object sender, EventArgs e)
        {
            t2.BackColor = Color.White;
        }

        private void t3_Enter(object sender, EventArgs e)
        {
            t3.BackColor = Color.White;
        }

        private void t1_Leave(object sender, EventArgs e)
        {
            t1.BackColor = Color.LightSlateGray;
        }

        private void t2_Leave(object sender, EventArgs e)
        {
            t2.BackColor = Color.LightSlateGray;
        }

        private void t3_Leave(object sender, EventArgs e)
        {
            t3.BackColor = Color.LightSlateGray;
        }

        private void t4_Leave(object sender, EventArgs e)
        {
            t4.BackColor = Color.LightSlateGray;
        }

        private void t5_Leave(object sender, EventArgs e)
        {
            t5.BackColor = Color.LightSlateGray;
        }

        private void t6_Leave(object sender, EventArgs e)
        {
            t6.BackColor = Color.LightSlateGray;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void change_pass_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\1.png");
            pictureBox2.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\2.png");
        }
    }
}