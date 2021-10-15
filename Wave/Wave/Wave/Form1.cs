//////////////////////////////////////
//              Hani                //
//          Tiny Turtle             //
//////////////////////////////////////


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wave
{
    public partial class Form1 : Form
    {
        // متغیر های سراسری
        Wave_Class.WaveControl Wave_Control = new Wave.Wave_Class.WaveControl();
        Pen MyPen = new Pen(Color.Red);
        Graphics Graph;

        // توابع
        public Form1()
        {
            InitializeComponent();
            Form1.CheckForIllegalCrossThreadCalls = false;
            Graph = PbxEqu.CreateGraphics();

        }

        private void btnPlayStop_Click(object sender, EventArgs e)
        {
            if (btnPlayStop.Text == "Play")
            {
                btnPlayStop.Text = (Wave_Control.Start(txtBrowse.Text, 5000, 10)) ? "Stop" : "Play";
                Wave_Control.BufferFiller += new Wave.Wave_Class.WaveControl.Filler(Wave_Control_BufferFiller);
                lblTotalByte.Text = "Size Data Byte : " + Wave_Control.info.Size_of_data;
                MusicBar.Maximum = Wave_Control.info.Size_of_data;

                Graph.DrawRectangle(MyPen, 10, 80, 110, 18);
                Graph.DrawRectangle(MyPen, 20, 62, 90, 18);
                Graph.DrawRectangle(MyPen, 30, 44, 70, 18);
                Graph.DrawRectangle(MyPen, 40, 26, 50, 18);
                Graph.DrawRectangle(MyPen, 50, 8, 30, 18);

                Graph.FillRectangle(new SolidBrush(Color.White), 10, 80, 110, 18);
                Graph.FillRectangle(new SolidBrush(Color.White), 20, 62, 90, 18);
                Graph.FillRectangle(new SolidBrush(Color.White), 30, 44, 70, 18);
                Graph.FillRectangle(new SolidBrush(Color.White), 40, 26, 50, 18);
                Graph.FillRectangle(new SolidBrush(Color.White), 50, 8, 30, 18);
            }
            else if (btnPlayStop.Text == "Stop")
            {
                Wave_Control.Stop();
                btnPlayStop.Text = "Play";

                Graph.Clear(Color.White);
            }
        }

        void Wave_Control_BufferFiller(IntPtr data, int size, byte[] PlayBuffer)
        {
            lblPlayByte.Text = "Play Byte : " + Wave_Control.info.PlayThisByte;
            MusicBar.Value = Wave_Control.info.PlayThisByte;
            Byte[] Equ = new Byte[size];
            int mynum = 0;
            //for (int i=0 ; i<=2 ; i++)
            //mynum += ();
            int j = 0;
            for (int i = 0; i < PlayBuffer.Length; i += 100)
            {
                if (PlayBuffer[i] <= 1)
                {
                    Graph.FillRectangle(new SolidBrush(Color.Red), 10, 80, 110, 18);
                    Graph.FillRectangle(new SolidBrush(Color.White), 20, 62, 90, 18);
                    Graph.FillRectangle(new SolidBrush(Color.White), 30, 44, 70, 18);
                    Graph.FillRectangle(new SolidBrush(Color.White), 40, 26, 50, 18);
                    Graph.FillRectangle(new SolidBrush(Color.White), 50, 8, 30, 18);
                }
                else if (PlayBuffer[i] <= 50)
                {
                    Graph.FillRectangle(new SolidBrush(Color.Red), 10, 80, 110, 18);
                    Graph.FillRectangle(new SolidBrush(Color.Red), 20, 62, 90, 18);
                    Graph.FillRectangle(new SolidBrush(Color.White), 30, 44, 70, 18);
                    Graph.FillRectangle(new SolidBrush(Color.White), 40, 26, 50, 18);
                    Graph.FillRectangle(new SolidBrush(Color.White), 50, 8, 30, 18);
                }
                else if (PlayBuffer[i] <= 100)
                {
                    Graph.FillRectangle(new SolidBrush(Color.Red), 10, 80, 110, 18);
                    Graph.FillRectangle(new SolidBrush(Color.Red), 20, 62, 90, 18);
                    Graph.FillRectangle(new SolidBrush(Color.Red), 30, 44, 70, 18);
                    Graph.FillRectangle(new SolidBrush(Color.White), 40, 26, 50, 18);
                    Graph.FillRectangle(new SolidBrush(Color.White), 50, 8, 30, 18);
                }
                else if (PlayBuffer[i] <= 150)
                {
                    Graph.FillRectangle(new SolidBrush(Color.Red), 10, 80, 110, 18);
                    Graph.FillRectangle(new SolidBrush(Color.Red), 20, 62, 90, 18);
                    Graph.FillRectangle(new SolidBrush(Color.Red), 30, 44, 70, 18);
                    Graph.FillRectangle(new SolidBrush(Color.Red), 40, 26, 50, 18);
                    Graph.FillRectangle(new SolidBrush(Color.White), 50, 8, 30, 18);
                }
                else if (PlayBuffer[i] <= 255)
                {
                    Graph.FillRectangle(new SolidBrush(Color.Red), 10, 80, 110, 18);
                    Graph.FillRectangle(new SolidBrush(Color.Red), 20, 62, 90, 18);
                    Graph.FillRectangle(new SolidBrush(Color.Red), 30, 44, 70, 18);
                    Graph.FillRectangle(new SolidBrush(Color.Red), 40, 26, 50, 18);
                    Graph.FillRectangle(new SolidBrush(Color.Red), 50, 8, 30, 18);
                }
            }


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Graph.DrawEllipse(MyPen, 10, 10, 30, 30);
            //Graph.DrawEllipse(MyPen, 35, 10, 30, 30);
            //Graph.DrawEllipse(MyPen, 70, 10, 30, 30);
            //Graph.DrawEllipse(MyPen, 95, 10, 30, 30);

            DlgBrowse.Filter = "Wave File (*.wav)|";
            DlgBrowse.ShowDialog();
            txtBrowse.Text = DlgBrowse.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
