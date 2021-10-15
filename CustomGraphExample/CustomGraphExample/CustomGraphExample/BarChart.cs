using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Text;


    public class BarChart: Panel
    {
        private ArrayList _BarCharts = new ArrayList();
        private string _cTitle;

        public void Add(ChartData bc)
        {
            this._BarCharts.Add(bc);
        }


        public string ChartTitle
        {
            set
            {
                _cTitle = value;
            }
        }

        public void BuildGraph()
        {
            BarChartPanel b = new BarChartPanel(this._BarCharts, _cTitle);
            this.Controls.Add(b);
            this.AutoSize = true;
        }
    }



    public class ChartData
    {
        private string _Key;
        private string _Value;
        private BarGradientColor _BgColor;

        public ChartData(string key, string value, BarGradientColor bgcolor)
        {
            _Key = key;
            _Value = value;
            _BgColor = bgcolor;
        }

        public void AddKey(string key)
        {
            _Key = key;
        }

        public void AddValue(string value)
        {
            _Value = value;
        }

        public string GetKey()
        {
            return this._Key;
        }

        public string GetValue()
        {
            return this._Value;
        }

        public BarGradientColor GetBgColor()
        {
            return this._BgColor;
        }
    }



    public class BarChartPanel : Panel
    {
        private ArrayList _alBarCharts;

        public BarChartPanel(ArrayList alBarCharts, string ChartTitle)
        {
            this.Dock = DockStyle.Fill;
            this._alBarCharts = alBarCharts;
            this._alBarCharts.Reverse();


                ChartTitle plChartTitle = new ChartTitle();
                plChartTitle.Dock = DockStyle.Top;
                plChartTitle.Height = 30;
                plChartTitle.BackColor = Color.Transparent;

                Label lblChartTitle = new Label();
                lblChartTitle.Text = ChartTitle;
                lblChartTitle.Font = new Font("arial", 14, FontStyle.Regular);
                lblChartTitle.AutoSize = true;
                lblChartTitle.BackColor = Color.Transparent;
                lblChartTitle.Padding = new Padding(5);

                plChartTitle.Controls.Add(lblChartTitle);
                
                foreach (object o in _alBarCharts)
                {
                    string key = ((ChartData)o).GetKey();
                    string value = ((ChartData)o).GetValue();
                    BarGradientColor bgcolor = ((ChartData)o).GetBgColor();

                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    flp.BackColor = Color.Transparent;
                    flp.Width = this.Width;
                    flp.Height = 20;
                    flp.Dock = DockStyle.Top;

                    Label lblKey = new Label();
                    lblKey.BackColor = Color.Transparent;
                    lblKey.Padding = new Padding(5, 4, 0, 0);
                    lblKey.Font = new Font("tahoma", 8);
                    lblKey.Height = 17;
                    lblKey.Left = 10;
                    lblKey.Text = key;

                    ToolTip tooltip = new ToolTip();
                    tooltip.ToolTipTitle = key;

                    Bar bar = new Bar(bgcolor);
                    bar.Width = Convert.ToInt32(value);

                    Label lblValue = new Label();
                    lblValue.BackColor = Color.Transparent;
                    lblValue.Font = new Font("tahoma", 8);
                    lblValue.AutoSize = true;
                    lblValue.Padding = new Padding(0, 4, 0, 0);
                    lblValue.Text = value;


                    flp.Controls.Add(lblKey);
                    flp.Controls.Add(bar);
                    flp.Controls.Add(lblValue);

                    this.Controls.Add(flp);
                }

                Panel plBlank = new Panel();
                plBlank.Height = 20;
                plBlank.Dock = DockStyle.Top;
                plBlank.BackColor = Color.Transparent;

                this.Controls.Add(plBlank);
                this.Controls.Add(plChartTitle);
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle Rectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush gradient = new LinearGradientBrush(Rectangle, Color.FromArgb(251, 251, 251), Color.FromArgb(228, 226, 231), LinearGradientMode.Vertical);

            Pen graph_border = new Pen(Color.FromArgb(183, 183, 183));
            g.FillRectangle(gradient, Rectangle);
            g.DrawRectangle(graph_border, Rectangle);
        }
    }


    public class Bar : Panel
    {
        private Color _gradient1;
        private Color _gradient2;
        private Color _pen;

        public Bar(BarGradientColor bgcolor)
        {
            this.DoubleBuffered = true;
            this.Height = 17;

            if (bgcolor == BarGradientColor.Red)
            {
                this._gradient1 = Color.FromArgb(193, 0, 0);
                this._gradient2 = Color.FromArgb(255, 13, 13);
                this._pen = Color.FromArgb(193, 0, 0);
            }

            if (bgcolor == BarGradientColor.Green)
            {
                this._gradient1 = Color.FromArgb(0, 193, 0);
                this._gradient2 = Color.FromArgb(13, 255, 13);
                this._pen = Color.FromArgb(0, 193, 0);
            }

            if (bgcolor == BarGradientColor.Blue)
            {
                this._gradient1 = Color.FromArgb(79, 116, 183);
                this._gradient2 = Color.FromArgb(144, 195, 230);
                this._pen = Color.FromArgb(79, 116, 183);
            }

            if (bgcolor == BarGradientColor.Orange)
            {
                this._gradient1 = Color.FromArgb(231, 132, 0);
                this._gradient2 = Color.FromArgb(255, 198, 24);
                this._pen = Color.FromArgb(231, 132, 0);
            }

            if (bgcolor == BarGradientColor.Purple)
            {
                this._gradient1 = Color.FromArgb(102, 50, 102);
                this._gradient2 = Color.FromArgb(182, 141, 182);
                this._pen = Color.FromArgb(102, 50, 102);
            }

            if (bgcolor == BarGradientColor.Black)
            {
                this._gradient1 = Color.FromArgb(0, 0, 0);
                this._gradient2 = Color.FromArgb(100, 100, 100);
                this._pen = Color.FromArgb(0, 0, 0);
            }

            if (bgcolor == BarGradientColor.Silver)
            {
                this._gradient1 = Color.FromArgb(150, 150, 150);
                this._gradient2 = Color.FromArgb(255, 255, 255);
                this._pen = Color.FromArgb(150, 150, 150);
            }

            if (bgcolor == BarGradientColor.Lime)
            {
                this._gradient1 = Color.FromArgb(190, 227, 0);
                this._gradient2 = Color.FromArgb(128, 255,0);
                this._pen = Color.FromArgb(190, 227, 0);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            Rectangle bar = new Rectangle(0,0,this.Width-1,this.Height-1);
            Rectangle bar_top = new Rectangle(0, 0, this.Width, (this.Height / 2) + 2);
            Rectangle bar_bottom = new Rectangle(0, 10, this.Width, (this.Height / 2) + 2);
            LinearGradientBrush gradient_top = new LinearGradientBrush(bar_top, this._gradient1, this._gradient2, LinearGradientMode.Vertical);
            LinearGradientBrush gradient_bottom = new LinearGradientBrush(bar_bottom, this._gradient2, this._gradient1, LinearGradientMode.Vertical);

            Pen bar_border = new Pen(this._pen);
            
            g.FillRectangle(gradient_top, bar_top);
            g.FillRectangle(gradient_bottom, bar_bottom);
            g.DrawRectangle(bar_border, bar);
        }
    }



    class ChartTitle : Panel
    {
        public ChartTitle()
        {
            this.DoubleBuffered = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle Rectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb1 = new LinearGradientBrush(Rectangle, Color.FromArgb(251, 251, 251), Color.FromArgb(228, 226, 231), LinearGradientMode.Vertical);

            Pen pen1 = new Pen(Color.FromArgb(183, 183, 183));
            g.DrawLine(pen1, 0, this.Height - 1, this.Width, this.Height - 1);
            g.FillRectangle(lgb1, Rectangle);
        }
    }



    public enum BarGradientColor
    {
        Red,
        Green,
        Blue,
        Orange,
        Purple,
        Black,
        Silver,
        Lime
    };
