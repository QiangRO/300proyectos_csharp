using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Neon_Clock__CS_
{
    
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Neon_Clock()
        {
            string[] Img_Path = new string[10];
            string App_Path;
            App_Path=Application.StartupPath.ToString();
            
            
            //----------------------------------------------------------
            // Declare Variables.
            
            Img_Path[0] = App_Path + "\\Resource\\0.jpg";
            Img_Path[1] = App_Path + "\\Resource\\1.jpg";
            Img_Path[2] = App_Path + "\\Resource\\2.jpg";
            Img_Path[3] = App_Path + "\\Resource\\3.jpg";
            Img_Path[4] = App_Path + "\\Resource\\4.jpg";
            Img_Path[5] = App_Path + "\\Resource\\5.jpg";
            Img_Path[6] = App_Path + "\\Resource\\6.jpg";
            Img_Path[7] = App_Path + "\\Resource\\7.jpg";
            Img_Path[8] = App_Path + "\\Resource\\8.jpg";
            Img_Path[9] = App_Path + "\\Resource\\9.jpg";
            //----------------------------------------------------------
            // This Code For Hour.
            string Hour;
            Hour = DateTime.Now.TimeOfDay.Hours.ToString();
            switch (Hour)
            {
                case "0":
                    h1.Image = Image.FromFile (Img_Path[0]);
                    h2.Image = Image.FromFile (Img_Path[0]);
                    break;
                case "1":
                    h1.Image=Image.FromFile (Img_Path[0]);
                    h2.Image=Image.FromFile (Img_Path[1]);
                    break;
                case "2":
                    h1.Image=Image.FromFile (Img_Path[0]);
                    h2.Image=Image.FromFile (Img_Path[2]);
                    break;
                case "3":
                    h1.Image=Image.FromFile (Img_Path[0]);
                    h2.Image=Image.FromFile (Img_Path[3]);
                    break;
                case "4":
                    h1.Image=Image.FromFile (Img_Path[0]);
                    h2.Image=Image.FromFile (Img_Path[4]);
                    break;
                case "5":
                    h1.Image=Image.FromFile (Img_Path[0]);
                    h2.Image=Image.FromFile (Img_Path[5]);
                    break;
                case "6":
                    h1.Image=Image.FromFile (Img_Path[0]);
                    h2.Image=Image.FromFile (Img_Path[6]);
                    break;
                case "7":
                    h1.Image=Image.FromFile (Img_Path[0]);
                    h2.Image=Image.FromFile (Img_Path[7]);
                    break;
                case "8":
                    h1.Image=Image.FromFile (Img_Path[0]);
                    h2.Image=Image.FromFile (Img_Path[8]);
                    break;
                case "9":
                    h1.Image=Image.FromFile (Img_Path[0]);
                    h2.Image=Image.FromFile (Img_Path[9]);
                    break;
                case "10":
                    h1.Image=Image.FromFile (Img_Path[1]);
                    h2.Image=Image.FromFile (Img_Path[0]);
                    break;
                case "11":
                    h1.Image=Image.FromFile (Img_Path[1]);
                    h2.Image=Image.FromFile (Img_Path[1]);
                    break;
                case "12":
                    h1.Image=Image.FromFile (Img_Path[1]);
                    h2.Image=Image.FromFile (Img_Path[2]);
                    break;
                case "13":
                    h1.Image=Image.FromFile (Img_Path[1]);
                    h2.Image=Image.FromFile (Img_Path[3]);
                    break;
                case "14":
                    h1.Image=Image.FromFile (Img_Path[1]);
                    h2.Image=Image.FromFile (Img_Path[4]);
                    break;
                case "15":
                    h1.Image=Image.FromFile (Img_Path[1]);
                    h2.Image=Image.FromFile (Img_Path[5]);
                    break;
                case "16":
                    h1.Image=Image.FromFile (Img_Path[1]);
                    h2.Image=Image.FromFile (Img_Path[6]);
                    break;
                case "17":
                    h1.Image=Image.FromFile (Img_Path[1]);
                    h2.Image=Image.FromFile (Img_Path[7]);
                    break;
                case "18":
                    h1.Image=Image.FromFile (Img_Path[1]);
                    h2.Image=Image.FromFile (Img_Path[8]);
                    break;
                case "19":
                    h1.Image=Image.FromFile (Img_Path[1]);
                    h2.Image=Image.FromFile (Img_Path[9]);
                    break;
                case "20":
                    h1.Image=Image.FromFile (Img_Path[2]);
                    h2.Image=Image.FromFile (Img_Path[0]);
                    break;
                case "21":
                    h1.Image=Image.FromFile (Img_Path[2]);
                    h2.Image=Image.FromFile (Img_Path[1]);
                    break;
                case "22":
                    h1.Image=Image.FromFile (Img_Path[2]);
                    h2.Image=Image.FromFile (Img_Path[2]);
                    break;
                case "23":
                    h1.Image=Image.FromFile (Img_Path[2]);
                    h2.Image=Image.FromFile (Img_Path[3]);
                    break;
            
            }
            
            //------------------------------
            // This Code For Minute.
            string Minute;
            Minute = DateTime.Now.TimeOfDay.Minutes.ToString();
            switch (Minute)
            {
                case "0":
                    m1.Image = Image.FromFile(Img_Path[0]);
                    m2.Image = Image.FromFile(Img_Path[0]);
                    break;
                case "1":
                    m1.Image = Image.FromFile(Img_Path[0]);
                    m2.Image = Image.FromFile(Img_Path[1]);
                    break;
                case "2":
                    m1.Image = Image.FromFile(Img_Path[0]);
                    m2.Image = Image.FromFile(Img_Path[2]);
                    break;
                case "3":
                    m1.Image = Image.FromFile(Img_Path[0]);
                    m2.Image = Image.FromFile(Img_Path[3]);
                    break;
                case "4":
                    m1.Image = Image.FromFile(Img_Path[0]);
                    m2.Image = Image.FromFile(Img_Path[4]);
                    break;
                case "5":
                    m1.Image = Image.FromFile(Img_Path[0]);
                    m2.Image = Image.FromFile(Img_Path[5]);
                    break;
                case "6":
                    m1.Image = Image.FromFile(Img_Path[0]);
                    m2.Image = Image.FromFile(Img_Path[6]);
                    break;
                case "7":
                    m1.Image = Image.FromFile(Img_Path[0]);
                    m2.Image = Image.FromFile(Img_Path[7]);
                    break;
                case "8":
                    m1.Image = Image.FromFile(Img_Path[0]);
                    m2.Image = Image.FromFile(Img_Path[8]);
                    break;
                case "9":
                    m1.Image = Image.FromFile(Img_Path[0]);
                    m2.Image = Image.FromFile(Img_Path[9]);
                    break;
                case "10":
                    m1.Image = Image.FromFile(Img_Path[1]);
                    m2.Image = Image.FromFile(Img_Path[0]);
                    break;
                case "11":
                    m1.Image = Image.FromFile(Img_Path[1]);
                    m2.Image = Image.FromFile(Img_Path[1]);
                    break;
                case "12":
                    m1.Image = Image.FromFile(Img_Path[1]);
                    m2.Image = Image.FromFile(Img_Path[2]);
                    break;
                case "13":
                    m1.Image = Image.FromFile(Img_Path[1]);
                    m2.Image = Image.FromFile(Img_Path[3]);
                    break;
                case "14":
                    m1.Image = Image.FromFile(Img_Path[1]);
                    m2.Image = Image.FromFile(Img_Path[4]);
                    break;
                case "15":
                    m1.Image = Image.FromFile(Img_Path[1]);
                    m2.Image = Image.FromFile(Img_Path[5]);
                    break;
                case "16":
                    m1.Image = Image.FromFile(Img_Path[1]);
                    m2.Image = Image.FromFile(Img_Path[6]);
                    break;
                case "17":
                    m1.Image = Image.FromFile(Img_Path[1]);
                    m2.Image = Image.FromFile(Img_Path[7]);
                    break;
                case "18":
                    m1.Image = Image.FromFile(Img_Path[1]);
                    m2.Image = Image.FromFile(Img_Path[8]);
                    break;
                case "19":
                    m1.Image = Image.FromFile(Img_Path[1]);
                    m2.Image = Image.FromFile(Img_Path[9]);
                    break;
                case "20":
                    m1.Image = Image.FromFile(Img_Path[2]);
                    m2.Image = Image.FromFile(Img_Path[0]);
                    break;
                case "21":
                    m1.Image = Image.FromFile(Img_Path[2]);
                    m2.Image = Image.FromFile(Img_Path[1]);
                    break;
                case "22":
                    m1.Image = Image.FromFile(Img_Path[2]);
                    m2.Image = Image.FromFile(Img_Path[2]);
                    break;
                case "23":
                    m1.Image = Image.FromFile(Img_Path[2]);
                    m2.Image = Image.FromFile(Img_Path[3]);
                    break;
                case "24":
                    m1.Image = Image.FromFile(Img_Path[2]);
                    m2.Image = Image.FromFile(Img_Path[4]);
                    break;
                case "25":
                    m1.Image = Image.FromFile(Img_Path[2]);
                    m2.Image = Image.FromFile(Img_Path[5]);
                    break;
                case "26":
                    m1.Image = Image.FromFile(Img_Path[2]);
                    m2.Image = Image.FromFile(Img_Path[6]);
                    break;
                case "27":
                    m1.Image = Image.FromFile(Img_Path[2]);
                    m2.Image = Image.FromFile(Img_Path[7]);
                    break;
                case "28":
                    m1.Image = Image.FromFile(Img_Path[2]);
                    m2.Image = Image.FromFile(Img_Path[8]);
                    break;
                case "29":
                    m1.Image = Image.FromFile(Img_Path[2]);
                    m2.Image = Image.FromFile(Img_Path[9]);
                    break;
                case "30":
                    m1.Image = Image.FromFile(Img_Path[3]);
                    m2.Image = Image.FromFile(Img_Path[0]);
                    break;
                case "31":
                    m1.Image = Image.FromFile(Img_Path[3]);
                    m2.Image = Image.FromFile(Img_Path[1]);
                    break;
                case "32":
                    m1.Image = Image.FromFile(Img_Path[3]);
                    m2.Image = Image.FromFile(Img_Path[2]);
                    break;
                case "33":
                    m1.Image = Image.FromFile(Img_Path[3]);
                    m2.Image = Image.FromFile(Img_Path[3]);
                    break;
                case "34":
                    m1.Image = Image.FromFile(Img_Path[3]);
                    m2.Image = Image.FromFile(Img_Path[4]);
                    break;
                case "35":
                    m1.Image = Image.FromFile(Img_Path[3]);
                    m2.Image = Image.FromFile(Img_Path[5]);
                    break;
                case "36":
                    m1.Image = Image.FromFile(Img_Path[3]);
                    m2.Image = Image.FromFile(Img_Path[6]);
                    break;
                case "37":
                    m1.Image = Image.FromFile(Img_Path[3]);
                    m2.Image = Image.FromFile(Img_Path[7]);
                    break;
                case "38":
                    m1.Image = Image.FromFile(Img_Path[3]);
                    m2.Image = Image.FromFile(Img_Path[8]);
                    break;
                case "39":
                    h1.Image = Image.FromFile(Img_Path[3]);
                    h2.Image = Image.FromFile(Img_Path[9]);
                    break;
                case "40":
                    h1.Image = Image.FromFile(Img_Path[4]);
                    h2.Image = Image.FromFile(Img_Path[0]);
                    break;
                case "41":
                    m1.Image = Image.FromFile(Img_Path[4]);
                    m2.Image = Image.FromFile(Img_Path[1]);
                    break;
                case "42":
                    m1.Image = Image.FromFile(Img_Path[4]);
                    m2.Image = Image.FromFile(Img_Path[2]);
                    break;
                case "43":
                    m1.Image = Image.FromFile(Img_Path[4]);
                    m2.Image = Image.FromFile(Img_Path[3]);
                    break;
                case "44":
                    m1.Image = Image.FromFile(Img_Path[4]);
                    m2.Image = Image.FromFile(Img_Path[4]);
                    break;
                case "45":
                    m1.Image = Image.FromFile(Img_Path[4]);
                    m2.Image = Image.FromFile(Img_Path[5]);
                    break;
                case "46":
                    m1.Image = Image.FromFile(Img_Path[4]);
                    m2.Image = Image.FromFile(Img_Path[6]);
                    break;
                case "47":
                    m1.Image = Image.FromFile(Img_Path[4]);
                    m2.Image = Image.FromFile(Img_Path[7]);
                    break;
                case "48":
                    m1.Image = Image.FromFile(Img_Path[4]);
                    m2.Image = Image.FromFile(Img_Path[8]);
                    break;
                case "49":
                    m1.Image = Image.FromFile(Img_Path[4]);
                    m2.Image = Image.FromFile(Img_Path[9]);
                    break;
                case "50":
                    m1.Image = Image.FromFile(Img_Path[5]);
                    m2.Image = Image.FromFile(Img_Path[0]);
                    break;
                case "51":
                    m1.Image = Image.FromFile(Img_Path[5]);
                    m2.Image = Image.FromFile(Img_Path[1]);
                    break;
                case "52":
                    m1.Image = Image.FromFile(Img_Path[5]);
                    m2.Image = Image.FromFile(Img_Path[2]);
                    break;
                case "53":
                    m1.Image = Image.FromFile(Img_Path[5]);
                    m2.Image = Image.FromFile(Img_Path[3]);
                    break;
                case "54":
                    m1.Image = Image.FromFile(Img_Path[5]);
                    m2.Image = Image.FromFile(Img_Path[4]);
                    break;
                case "55":
                    m1.Image = Image.FromFile(Img_Path[5]);
                    m2.Image = Image.FromFile(Img_Path[5]);
                    break;
                case "56":
                    m1.Image = Image.FromFile(Img_Path[5]);
                    m2.Image = Image.FromFile(Img_Path[6]);
                    break;
                case "57":
                    m1.Image = Image.FromFile(Img_Path[5]);
                    m2.Image = Image.FromFile(Img_Path[7]);
                    break;
                case "58":
                    m1.Image = Image.FromFile(Img_Path[5]);
                    m2.Image = Image.FromFile(Img_Path[8]);
                    break;
                case "59":
                    m1.Image = Image.FromFile(Img_Path[5]);
                    m2.Image = Image.FromFile(Img_Path[9]);
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
         }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Neon_Clock();
        }
            
        }
    }
