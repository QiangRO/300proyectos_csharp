using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace abjd
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int vasit,kabir;

        public int abjad_vasit(int ascii_vasit)
        {
            
            switch (ascii_vasit)
            {
                case 1575: //ا = 1575   
                    vasit += 1;
                    break;
                case 1576: //ب = 1576  
                    vasit += 2;
                    break;
                case 1580:   //ج = 1580    
                    vasit += 3;
                    break;
                case 1583://د = 1583
                    vasit += 4;
                    break;
                case 1607://ه = 1607 
                    vasit += 5;
                    break;
                case 1608://و = 1608
                    vasit += 6;
                    break;
                case 1586:   //ز = 1586
                    vasit += 7;
                    break;
                case 1581:   //ح = 1581 
                    vasit += 8;
                    break;
                case 1591: //ط = 1591 
                    vasit += 9;
                    break;
                case 1609://ى = 1609   
                    vasit += 10;
                    break;
                case 1740://ي = 174
                    vasit += 10;
                    break;
                case 1610://ي = 1610 
                    vasit += 10; 
                    break;
                case 1603:// ك= 1603    
                    vasit += 11;
                    break;
                case 1604://ل = 1604    
                    vasit += 12;
                    break;
                case 1605://م = 1605    
                    vasit += 13;
                    break;
                case 1606://ن = 1606    
                    vasit += 14;
                    break;
                case 1587://س = 1587    
                    vasit += 15;
                    break;
                case 1593://ع = 1593    
                    vasit += 16;
                    break;
                case 1601://ف = 1601   
                    vasit += 17;
                    break;
                case 1589://ص = 1589  
                    vasit += 18;
                    break;
                case 1602://ق = 1602    
                    vasit += 19;
                    break;
                case 1585://ر = 1585    
                    vasit += 20;
                    break;
                case 1588://ش = 1588    
                    vasit += 21;
                    break;
                case 1578://ت = 1578    
                    vasit += 22;
                    break;
                case 179://ث = 1579  
                    vasit += 23;
                    break;
                case 1582://خ = 1582    
                    vasit += 24;
                    break;
                case 1584://ذ = 1584    
                    vasit += 25;
                    break;
                case 1590://ض = 1590    
                    vasit += 26;
                    break;
                case 1592://ظ = 1592    
                    vasit += 27;
                    break;
                case 1594://غ = 1594    
                    vasit += 28;
                    break;
                //default:
                    //vasit = vasit;
                   // break;
            }

            return vasit;
        }
       
        public  int abjad_kabir(int ascii_kabir) {
          // int a;
            switch (ascii_kabir)
            {
                case 1575: //ا = 1575   
                    kabir += 1;
                    break;
                case 1576: //ب = 1576  
                     kabir += 2;
                     break;
                 case 1580:   //ج = 1580    
                     kabir += 3;
                    break; 
                case 1583://د = 1583
                    kabir += 4;
                    break;
                case 1607://ه = 1607 
                    kabir += 5;
                    break;
                case 1608://و = 1608
                    kabir += 6;
                    break;
                case 1586:   //ز = 1586
                    kabir += 7;
                    break;
                case 1581:   //ح = 1581 
                    kabir += 8;
                    break;
                case 1591: //ط = 1591 
                    kabir += 9;
                    break;
                case 1609://ى = 1609   
                    kabir += 10; 
                    break;
                case 1740://ي = 174
                    kabir += 10; 
                    break;
                case 1610:
                    kabir += 10;//ي = 1610  
                    break;
                case 1603:// ك= 1603    
                    kabir += 20;
                    break;
                case 1604://ل = 1604    
                    kabir += 30;
                    break;
                case 1605://م = 1605    
                    kabir += 40;
                    break;
                case 1606://ن = 1606    
                    kabir += 50;
                    break;
                case 1587://س = 1587    
                    kabir += 60;
                    break;
                case 1593://ع = 1593    
                    kabir += 70;
                    break;
                case 1601://ف = 1601   
                    kabir += 80;
                    break;
                case 1589://ص = 1589  
                    kabir += 90;
                    break;
                case 1602://ق = 1602    
                    kabir += 100;
                    break;
                case 1585://ر = 1585    
                    kabir += 200;
                    break;
                case 1588://ش = 1588    
                    kabir += 300;
                    break;
                case 1578://ت = 1578    
                    kabir += 400;
                    break;  
                case 179://ث = 1579  
                    kabir += 500;
                    break;
                case 1582://خ = 1582    
                    kabir += 600;
                    break;
                case 1584://ذ = 1584    
                    kabir += 700;
                    break;
                case 1590://ض = 1590    
                    kabir +=800;
                    break;
                case 1592://ظ = 1592    
                    kabir += 900;
                    break;
                case 1594://غ = 1594    
                    kabir += 1000;
                   break;
            }
     
           return kabir;
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string a;
            int asc;
            kabir = 0;
            vasit = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                textBox2.Text = Convert.ToString(abjad_kabir(Char.ConvertToUtf32(textBox1.Text.Substring(i, 1), 0)));
                txtvasit.Text = Convert.ToString(abjad_vasit(Char.ConvertToUtf32(textBox1.Text.Substring(i, 1), 0)));
                a = textBox1.Text.Substring(i, 1);
                asc = Char.ConvertToUtf32(a, 0);

                maskedTextBox1.Text = textBox1.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));

        }

    }
}