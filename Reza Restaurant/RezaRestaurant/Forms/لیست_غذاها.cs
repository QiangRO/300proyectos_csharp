using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RezaRestaurant.Classes;

namespace RezaRestaurant.Forms
{
    public partial class Form_لیست_غذاها : Form
    {
        public Form_لیست_غذاها()
        {
            InitializeComponent();

            this.Height = SystemInformation.PrimaryMonitorSize.Height-200;
            this.Top = 100;
            this.Left = 100;
            FillListView();

            lvwColumnSorter = new ListViewColumnSorter();
            listView_لیست_غذاها.ListViewItemSorter = lvwColumnSorter;
        }

        void FillListView()
        {
            using (RezaRestaurant.SQL.DataClasses1DataContext dbc = new RezaRestaurant.SQL.DataClasses1DataContext())
            {
                var foods = from q in dbc.غذاهاs 
                            orderby q.کد_غذا ascending
                            select q;
                foreach (var item in foods)
                {
                    ListViewItem newListViewItem = new ListViewItem(new string[] { 
                                                                        item.نام_غذا.ToString().ToPersianNumber(), 
                                                                        item.کد_غذا.ToString().ToPersianNumber() });
                    newListViewItem.Font = new Font("Tahoma", 12);
                    listView_لیست_غذاها.Items.Add(newListViewItem);
                }
            }
        }

        private void Form_لیست_غذاها_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaticVariables.Form_لیست_غذاها_IsShown = false;
        }

        private void Form_لیست_غذاها_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }

        #region Sorting ListView

        private ListViewColumnSorter lvwColumnSorter;

        private void listView_فاکتور_Click(object sender, ColumnClickEventArgs e)
        {
            try
            {
                // Determine if clicked column is already the column that is being sorted.
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    if (lvwColumnSorter.Order == SortOrder.Ascending)
                    {
                        lvwColumnSorter.Order = SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorter.Order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                this.listView_لیست_غذاها.Sort();
            }
            catch { }
        }

        #endregion
    }
}
