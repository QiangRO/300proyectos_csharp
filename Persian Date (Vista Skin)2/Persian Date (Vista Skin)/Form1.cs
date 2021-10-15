using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Persian_Date__Vista_Skin_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Persian_Date()
        {
            //############################################################################################
            //Get Persian Date.
            System.Globalization.PersianCalendar PrsClnd = new System.Globalization.PersianCalendar();
            DateTime DT = DateTime.Now;
            int Year;
            int Month;
            int Day;
            Year = PrsClnd.GetYear(DT);
            Month = PrsClnd.GetMonth(DT);
            Day = PrsClnd.GetDayOfMonth(DT);
            //############################################################################################

            //############################################################################################
            //Declare Variables.
            string App_Path;
            App_Path = Application.StartupPath.ToString();
            //-------------------------------------------
            string[] Img = new String[10];
            for (int i = 0; i < 10; i++)
            {
                Img[i] = App_Path + "\\Resource\\" + i.ToString() + ".jpg";
            }
            //-------------------------------------------
            PictureBox[] Pbx = new PictureBox[8];
            Pbx[0] = y1;
            Pbx[1] = y2;
            Pbx[2] = y3;
            Pbx[3] = y4;
            Pbx[4] = m1;
            Pbx[5] = m2;
            Pbx[6] = d1;
            Pbx[7] = d2;

            //############################################################################################
            int p = 0;
            {
                //This Block Code For Year.
                int d = 1000;
 
                while (d >= 1)
                {
                    int y = (int)Year / d;
                    Pbx[p++].Image = Image.FromFile(Img[y]);
                    Year -= d * y;
                    d = d / 10;
                }
            }
            {
                //This Block Code For Month.
                int d = 10;
                while (d >= 1)
                {
                    int m = (int)Month / d;
                    Pbx[p++].Image = Image.FromFile(Img[m]);
                    Month -= d * m;
                    d = d / 10;
                }
            }
            {
                //This Block Code For Day.
                int d = 10;
                while (d >= 1)
                {
                    int R = (int)Day / d;
                    Pbx[p++].Image = Image.FromFile(Img[R]);
                    Day -= d * R;
                    d = d / 10;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Pogrammer : Alireza Zare " + "\n" + "Y-Mail : alireza_2297@yahoo.com" + "\n" + "G-Mail : jacksmith354@yahoo.com" + "\n" + "Web : www.ali-virus.blogfa.com" + "\n\n" + "Edited by Mohammad yaser sadegh" + "\n" + "Gmail: MYS2005.co@gmail.com", "Information : ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Persian_Date();
        }
    }
}

       
    
    



