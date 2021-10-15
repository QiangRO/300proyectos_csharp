using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GmailClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int number = 0;
        private DataSet JoinBox(ref int count)
        {
            DataSet ds = new DataSet();
            try
            {
                System.Xml.XmlUrlResolver xml = new System.Xml.XmlUrlResolver();
                xml.Credentials = new System.Net.NetworkCredential(textBox1.Text, textBox2.Text);
                System.Xml.XmlTextReader xmlread = new System.Xml.XmlTextReader(@"https://mail.google.com/mail/feed/atom");
                xmlread.XmlResolver = xml;

                ds.ReadXml(xmlread);
                count = ds.Tables[2].Rows.Count;

            }
            catch
            { }
            return ds;
        }
        private void listview(DataSet ds)
        {
           
           var join=(from DataRow  row in ds.Tables[2].Rows 
                     join DataRow  aut in ds.Tables[3].Rows 
                     on  row[2] equals aut[2]
                     select new {title=row[0].ToString() ,summary=row[1].ToString()
                     ,modified = row[3].ToString(),From =aut[0].ToString(),email =aut[1].ToString()
                     }).ToList();
           listView1.Items.Clear();
            foreach(var obj in join)
            {
                ListViewItem lst = new ListViewItem(obj.title);
                lst.SubItems.Add(obj.summary);
                lst.SubItems.Add(obj.From);
                   
                lst.SubItems.Add(obj.email);
                lst.SubItems.Add(obj.modified);
                listView1.Items.Add(lst);
              }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           

           // string address = @"https://" + textBox1.Text + " : " + textBox2.Text + " @ gmail.google.com/gmail/feed/atom";
           //   System.Net.WebRequest req = System.Net.WebRequest.Create(address);
           
           // System.Net.WebResponse res = req.GetResponse();
           // System.IO.Stream sr = res.GetResponseStream();
           //// System.IO.StreamWriter sw=new System.IO.StreamWriter(@"g:\1.txt");
           //      System.Data.DataSet ds = new DataSet();
           //   ds.ReadXml(sr);
            int i = number;
           DataSet ds= JoinBox(ref i);
           if (ds == null)
           {
               MessageBox.Show("Invalid UserName or Password");
               return;
           }
           if (i != number)
           {
              
 
               listview(ds);
               if (i > number)
               {
                   notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                   notifyIcon1.BalloonTipText = (i - number).ToString() + " New Message";
                   notifyIcon1.BalloonTipTitle = "New Message";
               }
              number= i ;
              notifyIcon1.ShowBalloonTip(10000);
           }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = number;
            DataSet ds = JoinBox(ref i);
            if (ds == null)
            {
                MessageBox.Show("Invalid UserName or Password");
                return;
            }
            if (i != number)
            {
                listview(ds);
                if (i > number)
                {
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipText = (i - number).ToString() + " New Message";
                    notifyIcon1.BalloonTipTitle = "New Message";
                }
                number = i;
                notifyIcon1.ShowBalloonTip(10000);
                
            }
        }

      

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", @"http://mail.google.com/mail/");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", @"http://mail.google.com/mail/");
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
                {
                case "Show":
                        this.Show();
                        break;
                case "To Try":
                        this.Hide();
                        break;
                case "Exit":
                        this.Close();
                        break;


                }
        }

     
        
    }
}
