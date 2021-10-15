using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;

namespace DraggableForm
{
    public class clsMethod
    {
        
        public clsMethod()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        //Create method for filling Listview control
        //I declared an array string equal to the numbers of columns, and
        //then I filled this array with the help of a counter loop, using 
        //a foreach loop to ensure that each row has been filled. 
        
        public static void WriteListView(DataSet objDS, ListView vlistView)
        {
            DataTable objDT=objDS.Tables[0];
            string[] str=new string[objDS.Tables[0].Columns.Count];
            
            //adding Datarows as listview Grids

            foreach (DataRow objRR in objDT.Rows)
            {
                
                for (int col = 0; col <= objDS.Tables[0].Columns.Count - 1; col++)
                {
                    str[col] = objRR[col].ToString();
                }
                ListViewItem ii;
                ii = new ListViewItem(str);
                vlistView.Items.Add(ii);
            } 
        } 
    }
}
