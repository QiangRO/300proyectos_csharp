using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Management;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace diskdrive
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            idsconected = new string[50];
            controlfordelet = new string[50];
            idssaved = new string[500];
            refresh();
            loadsaveids();
 }
        private int xloc = -105;
        private int yloc = 285;
        public string idforsave;
        private string[] idsconected;
        private string[] controlfordelet;
        private string[] idssaved;
        private static System.Timers.Timer aTimer;
        private void saveids(string idname, string idno)
        {
            System.IO.StreamReader filer = new System.IO.StreamReader("ids.dat");
            string tmp = filer.ReadToEnd();
            filer.Close();
            
            string[] chs = tmp.Split('+');
            string[] tmp3;
            for (int i = 0; i != chs.Length-1;i++)
            {
                
                if (!issaved(textBox2.Text)) {
                     System.IO.StreamWriter file = new System.IO.StreamWriter("ids.dat");
                    file.Write(tmp + idname + ":" + idno + "+");
                    file.Close();
                }
            }
            if (chs.Length == 1) {
                System.IO.StreamWriter file = new System.IO.StreamWriter("ids.dat");    
                file.Write(idname + ":" + idno + "+");
                file.Close();
            }


            loadsaveids();
            
        }
        private bool issaved(string c) 
        {
            if (c == "")
                return false;
            System.IO.StreamReader filer = new System.IO.StreamReader("ids.dat");
            string tmp = filer.ReadToEnd();
            filer.Close();
            string[] chs = tmp.Split('+');
            string[] tmp3;
            for (int io=0; chs.Length!=io; io++)
            {
                tmp3 = chs[io].Split(':');
                if(tmp3.Length==2)
                 if (c == tmp3[1])
                    return true;
            }
            return false;
        }
        private void loadsaveids()
        {
            checkedListBox1.Items.Clear();
            deletchekbox();
            System.IO.StreamReader file = new System.IO.StreamReader("ids.dat");
            string tmp=file.ReadToEnd();//idname+":"+idno+"::"
            file.Close();
            string[] chs=tmp.Split('+');
            string[] tmp3;
           for (int i = 0; i != chs.Length-1; i++)
           {
                tmp3=chs[i].Split(':');
                if (isconected(tmp3[1]) == 1)
                {
                //    addchekbox(tmp3[0], tmp3[0], true);
                    controlfordelet[i] = tmp3[0];
                    checkedListBox1.Items.Add(tmp3[0], true);
                    


                }
                else
                {
                   // addchekbox(tmp3[0], tmp3[0], false);
                    controlfordelet[i] = tmp3[0];
                    checkedListBox1.Items.Add(tmp3[0],false);
                }
            
           }


            
            
            
            
          
        }
        private void button1_Click(object sender, EventArgs e)
        {

            refresh();
            loadsaveids();
            }
        private int isconected(string idforchek)
        {
            for (int i = 0; i != idsconected.Length; i++)
            {
                if (idforchek == idsconected[i])
                    return 1;
            }
            return 0;
        }
        private void deletchekbox() 
        
        {
            if (controlfordelet.Length != 0)
                for (int i = 0; controlfordelet.Length != i; i++)
                    this.Controls.RemoveByKey(controlfordelet[i]);
        xloc = -105;
         yloc = 285;
        }
        private void refresh()
        {
            for (int j = 0; j != idsconected.Length; j++) 
            {
                idsconected[j] = "";
            }
            listBox1.Items.Clear();
            string tmp;
            System.Management.ManagementObjectSearcher mg = new ManagementObjectSearcher("select * from win32_diskdrive");
            int i = 0;
            foreach (ManagementObject mgobj in mg.Get())
            {
                tmp = mgobj.GetPropertyValue("pnpdeviceid").ToString();
                idsconected[i] = tmp;
                listBox1.Items.Add(tmp);
                i++;
            }
          
        }
        private void addchekbox(string name, string text,bool che)
        {
            if (xloc == 375)
            {
                if (yloc != 310)
                {
                    xloc = 15;
                    yloc += 25;
                }
                else
                {
                    return;
                }
            }
            
            xloc += 120;
                 CheckBox ch1 = new CheckBox();
                 ch1 = new System.Windows.Forms.CheckBox();
                 ch1.AutoCheck = false;
                 ch1.AutoSize = true;
                 ch1.Location = new System.Drawing.Point(xloc, yloc);
                 ch1.Name = name;
                 ch1.Size = new System.Drawing.Size(50, 17);
                 ch1.TabIndex = 5;
                 ch1.Text = text;
                 ch1.UseVisualStyleBackColor = true;
                 this.Controls.Add(ch1);
                 ch1.Checked = che;
            //System.Windows.Forms.


        
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            /*
           
          
             */
            if (idforsave != null)
            {
                saveids(textBox1.Text, textBox2.Text);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            refresh();
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                idforsave = listBox1.SelectedItem.ToString();
                button2.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Text = idforsave;
                string[] u = idforsave.Split('&');
                textBox1.Text = u[2];
            }

            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadsaveids();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
            loadsaveids();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        

    }
}