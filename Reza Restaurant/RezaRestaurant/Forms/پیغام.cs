using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RezaRestaurant
{
    public partial class Form_پیغام : Form
    {
        public Form_پیغام(string Message)
        {
            InitializeComponent();
            label_متن_پیغام.Text = Message;
        }

        private void button01_Click(object sender, EventArgs e)
        {
            StaticVariables.Message = button01.Text;
            this.Close();
        }

        private void button02_Click(object sender, EventArgs e)
        {
            StaticVariables.Message = button02.Text;
            this.Close();
        }

        private void Form_پیغام_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
