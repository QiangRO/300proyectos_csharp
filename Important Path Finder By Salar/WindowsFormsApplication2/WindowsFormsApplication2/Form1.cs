using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string win = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                    c.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Environment.SystemDirectory.ToString();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            string[] drv_name;
            drv_name = Environment.GetLogicalDrives();
            string drv = "";
            foreach (string s in drv_name)
            {
                drv += s + "  " + " , ";
            }
            label4.Text = drv;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = Environment.UserName.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Time = 0;
            int H = 0, M = 0, S = 0;
            Time = Environment.TickCount;
            label6.Text = "Time of Starting Computer up to now is " + Time.ToString() + "Mili Seconds";


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                    c.Text = "";
            }
            //---------------------------------
            win = Environment.SystemDirectory.Substring(0, 3) + "SaveLog.txt";
            //---------------------------------
            if (File.Exists(@win)==true)
            {
                File.Delete(@win);
                MessageBox.Show("Information is Successfully Cleaned", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
            {
                MessageBox.Show("There is No Information to Clear", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void designerOfSoftWareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about;
            about = "نویسنده نرم افزار : سالار اشگی " + "\n\n" + "===================\n\n" + "تحت زبان سی شارپ 2008 " + "\n\n" + "===================\n\n" + "تابستان 87 ";
            MessageBox.Show(about, "درباره من ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string f = Environment.SystemDirectory.Substring(0,3);
             win=f+"SaveLog.txt";
            StreamWriter sw = new StreamWriter(@win);
            Label[] Lb = new Label[5];
            int i=0;
            foreach (Control c in this.Controls)
            {
                if (c is Label)

                    Lb[i] =(Label) c;
                i++;
            }
            string[] btn = new string[5];
            btn[0] = "Time of Start";
            btn[1] = "Active User";
            btn[2] = "Drives";
            btn[3] = "My Documents";
            btn[4] = "Windows";
            //---------------------------
            for (int j = 0; j < 5; j++)
            {
                sw.WriteLine(btn[4 - j] +" = "+ Lb[4 - j].Text.ToString());
              
                sw.WriteLine("-------------------------\n\n");
                
            }
            MessageBox.Show("Information is Saved Successfully in "+win, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sw.Flush();
            sw.Close();

            
           


        }
    }
}
