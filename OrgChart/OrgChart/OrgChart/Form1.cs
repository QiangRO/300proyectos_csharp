using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dotnetCHARTING.WinForms;

namespace OrgChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         CreateChart(ref Chart1);
        }




        public void CreateChart(ref Chart Chart1)
        {


            // This sample demonstrates usage of an organization chart using custom attributes populated from an existing user table by adding instance and parent IDs to establish the org hierarchy.

            // Set global properties
            Chart1.Type = ChartType.Organizational;
            Chart1.TempDirectory = "temp";
            Chart1.Debug = true;
            Chart1.Size = new Size(950,750);

            Chart1.ChartArea.Background.ShadingEffectMode = ShadingEffectMode.Five;
            Chart1.ChartArea.Background.Color = Color.FromArgb(250, Color.FromArgb(180, 200, 224));

            // TitleBox Customization
            Chart1.TitleBox.Label.Text = " Acme Company's Organization Chart";
            Chart1.TitleBox.Label.Color = Color.White;
            Chart1.TitleBox.Label.Shadow.Color = Color.FromArgb(105, 0, 0, 0);
            Chart1.TitleBox.Label.Shadow.Depth = 2;
            Chart1.TitleBox.Background.ShadingEffectMode = ShadingEffectMode.Two;
            Chart1.TitleBox.Background.Color = Color.SteelBlue;

            // Set the org line style
            Chart1.DefaultSeries.Line.Width = 5;
            Chart1.DefaultSeries.Line.Color = Color.DarkGray;

            // Set the org annotation visual appearance, shading and layout
            Chart1.DefaultElement.Annotation = new Annotation();
            Chart1.DefaultElement.Annotation.Label.Alignment = StringAlignment.Center;
            Chart1.DefaultElement.Annotation.Background.ShadingEffectMode = ShadingEffectMode.Seven;
            Chart1.DefaultElement.Annotation.Background.Color = Chart1.Palette[2];
            Chart1.DefaultElement.Annotation.Padding = 15;
            Chart1.DefaultElement.Annotation.Label.Text = "<block fStyle='bold' fSize='25'>%name<row><img:c:/chart/Org%picture><block halign='right'>%Department<br>%Email<br>%phone<br>Office #%office";

            // Controls the padding of the annotations within the chart area
            Chart1.ChartArea.Padding = 30;

            // Obtain series data from the database.  Note this was created by adding PID (parentid)
            // to an existing table only, then populating the parentid based on the hiearchy in place.
            DataEngine de = new DataEngine(@"Provider=Microsoft.Jet.OLEDB.4.0;data source=c://chart/chartsample.mdb");
            de.SqlStatement = @"SELECT * FROM Employees";
            de.DataFields = "InstanceID=ID,InstanceParentID=PID,Name=Name,office,Department,Email,Phone,Picture";
            Chart1.SeriesCollection.Add(de.GetSeries());


        }



    }
}
