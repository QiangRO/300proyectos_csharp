using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomGraphExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BarChart chart1 = new BarChart();
            chart1.Width = 500;
            chart1.Height = 150;
            chart1.Location = new Point(5, 5);
            chart1.ChartTitle = "Project Statistics";
            chart1.Add(new ChartData("Project A", "54", BarGradientColor.Blue));
            chart1.Add(new ChartData("Project B", "156", BarGradientColor.Green));
            chart1.Add(new ChartData("Project C", "210", BarGradientColor.Red));
            chart1.Add(new ChartData("Project D", "250", BarGradientColor.Orange));
            chart1.BuildGraph();

            this.Controls.Add(chart1);
        }
    }
}
