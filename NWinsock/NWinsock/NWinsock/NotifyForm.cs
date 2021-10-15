using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control.Notify;

namespace NWinsock
{
    public partial class NotifyForm : Form
    {
        public NotifyForm()
        {
            InitializeComponent();
            notifyListener.Listen();
            InitData();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            notifySender.Send(new Control.Notify.NWinsockData { Action= ActionType.None, 
                                  ApplicationName="NotifyTester", 
                                  DataType= DataType.DataTable ,    
                                  Context=sourceListBox.DataSource , 
                                  Subject="Transfer DataTable"        }, CompressionType.DeflateStream); 
        }

        private void notifyListener_ConnectionRequest(object sender, NotifyRequestEventArgs e)
        {
            notifyListener.Accept(e.Request);   
        }

        private void notifyListener_DataArrival(object sender, NotifyDataArrivalEventArgs e)
        {
            if (e.Data.DataType == DataType.DataTable)
                destListBox.DataSource = (DataTable)e.Data.Context;   
        }


        private void InitData()
        {
            DataTable dt = new DataTable("Items");
            dt.Columns.AddRange(new DataColumn[] {new DataColumn("ID",typeof(int)),new DataColumn("Name",typeof(string))});

            dt.Rows.Add(1,"Item 1");
            dt.Rows.Add(2,"Item 2");
            dt.Rows.Add(3,"Item 3");
            dt.Rows.Add(4,"Item 4");
            dt.Rows.Add(5,"Item 5");

            sourceListBox.DataSource = dt;  
        }

        private void NotifyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyListener.Close(); 
        }
    }
}
