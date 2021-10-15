using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace DraggableForm
{

   public class clsPublic
        {
            //Create public database connection object
       public static OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\DB\\Membership.mdb");
            //Declare public boolean variable
            public static bool BoolUpdateObjectRec;
            public static bool BoolUpdateComputerRec;
            public static bool BoolUpdateResponsableRec;
            public static bool BoolUpdateBorrowingRec;

            public clsPublic()
            {
                //
                // TODO: Add constructor logic here
                //
            }
        }
}
