using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_2
{
    public partial class Form2 : Form
    {
                
        public string Login
        {
            get { return LogintextBox.Text; }
            set { LogintextBox.Text = value; }
        }


        public string Password
        {
            get { return PasswordtextBox.Text; }
            set { PasswordtextBox.Text = value; }
        }

        public string Message
        {
            get { return MessageLbl.Text; }
            set { MessageLbl.Text = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
