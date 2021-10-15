using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean top = true;
        public Boolean left = true;
        public int Speed =25;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (top == true) Form1.ActiveForm.Top += Speed; else Form1.ActiveForm.Top -= Speed;
                if (left == true) Form1.ActiveForm.Left += Speed; else Form1.ActiveForm.Left -= Speed;

                if (Form1.ActiveForm.Top >= Screen.PrimaryScreen.Bounds.Height - 40) top = false;
                if (Form1.ActiveForm.Left >= Screen.PrimaryScreen.Bounds.Width - 37) left = false;
                if (Form1.ActiveForm.Top < -5) top = true;
                if (Form1.ActiveForm.Left < -5) left = true;
            }
            catch
            {
                timer1.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}