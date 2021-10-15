using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization; //

namespace IpBox
{

    // manually set to enable this control to be added into the toolbox
    [ToolboxItem(true)]

    interface IpBox_Control
    {
        IPAddress GetIPAddress { set; get; }
    }

    [ToolboxBitmap(typeof(IpBox))]
    public class IpBox : System.Windows.Forms.UserControl, IpBox_Control
    {
        #region Ctor

        public IpBox()
        {
            InitializeComponent();
        } 
        #endregion
        #region Fields

        private TextBox ip1;
        private TextBox ip2;
        private TextBox ip3;
        private TextBox ip4;

        private Label dotLabel1;
        private Label dotLabel2;
        private Label dotLabel3;
        private string address;

        private Panel p; 
        #endregion
        #region GetIPAddress

        public IPAddress GetIPAddress
        {
            get
            {
                address = int.Parse((ip1.Text.Length > 0) ? ip1.Text : "0").ToString()
                    + "." +
                    int.Parse((ip2.Text.Length > 0) ? ip2.Text : "0").ToString()
                    + "." +
                    int.Parse((ip3.Text.Length > 0) ? ip3.Text : "0").ToString()
                    + "." +
                    int.Parse((ip4.Text.Length > 0) ? ip4.Text : "0").ToString();

                return IPAddress.Parse(address);
            }
            set { }
        } 
        #endregion
        #region InitializeComponent

        private void InitializeComponent()
        {
            this.p = new System.Windows.Forms.Panel();
            this.ip1 = new System.Windows.Forms.TextBox();
            this.ip2 = new System.Windows.Forms.TextBox();
            this.ip3 = new System.Windows.Forms.TextBox();
            this.ip4 = new System.Windows.Forms.TextBox();
            this.dotLabel1 = new System.Windows.Forms.Label();
            this.dotLabel2 = new System.Windows.Forms.Label();
            this.dotLabel3 = new System.Windows.Forms.Label();
            this.p.SuspendLayout();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.White;
            this.p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p.Controls.Add(this.ip1);
            this.p.Controls.Add(this.ip2);
            this.p.Controls.Add(this.ip3);
            this.p.Controls.Add(this.ip4);
            this.p.Controls.Add(this.dotLabel1);
            this.p.Controls.Add(this.dotLabel2);
            this.p.Controls.Add(this.dotLabel3);
            this.p.Location = new System.Drawing.Point(0, 0);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(112, 25);
            this.p.TabIndex = 0;
            // 
            // ip1
            // 
            this.ip1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip1.Location = new System.Drawing.Point(2, 3);
            this.ip1.MaxLength = 3;
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(20, 13);
            this.ip1.TabIndex = 0;
            this.ip1.Text = "0";
            this.ip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ip1.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // ip2
            // 
            this.ip2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip2.Location = new System.Drawing.Point(28, 3);
            this.ip2.MaxLength = 3;
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(20, 13);
            this.ip2.TabIndex = 1;
            this.ip2.Text = "0";
            this.ip2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ip2.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // ip3
            // 
            this.ip3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip3.Location = new System.Drawing.Point(56, 3);
            this.ip3.MaxLength = 3;
            this.ip3.Name = "ip3";
            this.ip3.Size = new System.Drawing.Size(20, 13);
            this.ip3.TabIndex = 2;
            this.ip3.Text = "0";
            this.ip3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ip3.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // ip4
            // 
            this.ip4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip4.Location = new System.Drawing.Point(84, 3);
            this.ip4.MaxLength = 3;
            this.ip4.Name = "ip4";
            this.ip4.Size = new System.Drawing.Size(20, 13);
            this.ip4.TabIndex = 3;
            this.ip4.Text = "0";
            this.ip4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ip4.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // dotLabel1
            // 
            this.dotLabel1.BackColor = System.Drawing.Color.White;
            this.dotLabel1.Location = new System.Drawing.Point(25, -5);
            this.dotLabel1.Name = "dotLabel1";
            this.dotLabel1.Size = new System.Drawing.Size(1, 25);
            this.dotLabel1.TabIndex = 4;
            this.dotLabel1.Text = ".";
            this.dotLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dotLabel2
            // 
            this.dotLabel2.BackColor = System.Drawing.Color.White;
            this.dotLabel2.Location = new System.Drawing.Point(53, -5);
            this.dotLabel2.Name = "dotLabel2";
            this.dotLabel2.Size = new System.Drawing.Size(1, 25);
            this.dotLabel2.TabIndex = 5;
            this.dotLabel2.Text = ".";
            this.dotLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dotLabel3
            // 
            this.dotLabel3.BackColor = System.Drawing.Color.White;
            this.dotLabel3.Location = new System.Drawing.Point(81, -5);
            this.dotLabel3.Name = "dotLabel3";
            this.dotLabel3.Size = new System.Drawing.Size(1, 25);
            this.dotLabel3.TabIndex = 6;
            this.dotLabel3.Text = ".";
            this.dotLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IpBox
            // 
            this.Controls.Add(this.p);
            this.Name = "IpBox";
            this.Size = new System.Drawing.Size(112, 26);
            this.p.ResumeLayout(false);
            this.p.PerformLayout();
            this.ResumeLayout(false);

        } 
        #endregion
        #region OnTextChange

        private void OnTextChange(object sender, System.EventArgs e)
        {
            int box_type = 0;

            CultureInfo MyCultureInfo = new CultureInfo("en-GB");

            double d;

            if (sender.Equals(ip1))
                box_type = 1;
            if (sender.Equals(ip2))
                box_type = 2;
            if (sender.Equals(ip3))
                box_type = 3;
            if (sender.Equals(ip4))
                box_type = 4;

            switch (box_type)
            {
                case 1:

                    if (this.ip1.Text.Length > 0 && this.ip1.Text.ToCharArray()[this.ip1.Text.Length - 1] == '.')
                    {
                        this.ip1.Text = this.ip1.Text.TrimEnd('.');
                        ip1.Text = (this.ip1.Text.Length > 0) ? int.Parse(this.ip1.Text).ToString() : "0";
                        ip2.Focus();
                        return;
                    }

                    // integer validation
                    if (double.TryParse(
                        this.ip1.Text,
                        System.Globalization.NumberStyles.Integer,
                        MyCultureInfo,
                        out d) == false
                        )
                    {
                        this.ip1.Text = this.ip1.Text.Remove(0, this.ip1.Text.Length);
                        return;
                    }

                    // change focus to the next textbox if fully inserted
                    if (this.ip1.Text.Length == 3)
                    {
                        if (int.Parse(this.ip1.Text) >= 255)
                            this.ip1.Text = "255";
                        else
                            ip1.Text = int.Parse(ip1.Text).ToString();
                        ip2.Focus();
                    }
                    break;
                case 2:
                    if (this.ip2.Text.Length > 0 && this.ip2.Text.ToCharArray()[this.ip2.Text.Length - 1] == '.')
                    {
                        this.ip2.Text = this.ip2.Text.TrimEnd('.');
                        ip2.Text = (this.ip2.Text.Length > 0) ? int.Parse(this.ip2.Text).ToString() : "0";
                        ip3.Focus();
                        return;
                    }

                    if (double.TryParse(
                        this.ip2.Text,
                        System.Globalization.NumberStyles.Integer,
                        MyCultureInfo,
                        out d) == false
                        )
                    {
                        this.ip2.Text = this.ip2.Text.Remove(0, this.ip2.Text.Length);
                        return;
                    }

                    if (this.ip2.Text.Length == 3)
                    {
                        if (int.Parse(this.ip2.Text) >= 255)
                            this.ip2.Text = "255";
                        else
                            ip2.Text = int.Parse(ip2.Text).ToString();
                        ip3.Focus();
                    }
                    break;
                case 3:
                    if (this.ip3.Text.Length > 0 && this.ip3.Text.ToCharArray()[this.ip3.Text.Length - 1] == '.')
                    {
                        this.ip3.Text = this.ip3.Text.TrimEnd('.');
                        ip3.Text = (this.ip3.Text.Length > 0) ? int.Parse(this.ip3.Text).ToString() : "0";
                        ip4.Focus();
                        return;
                    }

                    if (double.TryParse(
                        this.ip3.Text,
                        System.Globalization.NumberStyles.Integer,
                        MyCultureInfo,
                        out d) == false
                        )
                    {
                        this.ip3.Text = this.ip3.Text.Remove(0, this.ip3.Text.Length);
                        return;
                    }

                    if (this.ip3.Text.Length == 3)
                    {
                        if (int.Parse(this.ip3.Text) >= 255)
                            this.ip3.Text = "255";
                        else
                            ip3.Text = int.Parse(ip3.Text).ToString();
                        ip4.Focus();
                    }
                    break;
                case 4:

                    if (double.TryParse(
                        this.ip4.Text,
                        System.Globalization.NumberStyles.Integer,
                        MyCultureInfo,
                        out d) == false
                        )
                    {
                        this.ip4.Text = this.ip4.Text.Remove(0, this.ip4.Text.Length);
                        return;
                    }

                    if (this.ip4.Text.Length == 3)
                    {
                        if (int.Parse(this.ip4.Text) >= 255)
                            this.ip4.Text = "255";
                        else
                            ip4.Text = int.Parse(ip4.Text).ToString();
                    }
                    break;
            }
        } 
        #endregion

    }
}