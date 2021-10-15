using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace SampleDLLDataGrid
{
   
        public class dataGridViewSpesific : DataGridView
        {

            public dataGridViewSpesific()
            {
                this.MouseWheel += new MouseEventHandler(dataGridViewSpesific_MouseWheel);
            }
  
            //------------------MouseWheel------------------------------------------------------
            private void dataGridViewSpesific_MouseWheel(object sender, MouseEventArgs e)
            {

                this.EndEdit();
                if (e.Delta.Equals(120) && this.CurrentRow.Index != 0)
                    SendKeys.Send("{Up}");

                else if (!e.Delta.Equals(120) && this.CurrentRow.Index != this.Rows.Count - 1)

                    SendKeys.Send("{Down}");
            }
            //------------------------------------------------------------------
            protected override bool ProcessDialogKey(Keys keyData)
            {
                Keys key = (keyData & Keys.KeyCode);
                if (key == Keys.F12)
                    if (this.CurrentRow.Index != this.RowCount - 1)
                        this.Rows.RemoveAt(this.CurrentRow.Index);
                if (key == Keys.Enter)
                {
                    if (this.CurrentCell == this[Columns.Count - 1, this.Rows[this.RowCount - 1].Index])
                    {
                        this.Rows.Add();
                    }

                    return this.ProcessTabKey(keyData);
                }
                return base.ProcessDialogKey(keyData);
            }

            [System.Security.Permissions.UIPermission(
          System.Security.Permissions.SecurityAction.LinkDemand,
          Window = System.Security.Permissions.UIPermissionWindow.AllWindows)]

            //-------------------------ProcessDataGridViewKey--------------------------------------------
            protected override bool ProcessDataGridViewKey(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                    return this.ProcessTabKey(e.KeyData);
                else
                    return base.ProcessDataGridViewKey(e);
            }

            //---------------------------------------------------------------------
        }

}
