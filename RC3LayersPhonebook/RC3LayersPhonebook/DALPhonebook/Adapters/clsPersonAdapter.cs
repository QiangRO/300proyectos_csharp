using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DALPhonebook.Adapters
{
    public class clsPersonAdapter : clsBaseAdapter<dsPhonebook.PersonsDataTable>
    {
        #region QUERIES
        const string _QUERY_SELECTALL_Persons =
            @"
                SELECT LastName , Tel , Address
                    FROM Persons
            ";
        const string _QUERY_SELECTALL_Persons_BY_LastName =
                    @"
                SELECT LastName , Tel , Address
                    FROM Persons
                    WHERE LastName = pLastName
            ";

        const string _QUERY_INSERT_Person =
            @"
                INSERT INTO Persons (LastName , Tel , Address)
                    VALUES(pLastName , pTel , pAddress)
            ";

        const string _QUERY_DELETE_Person_BY_LastName =
            @"
                DELETE FROM Persons
                    WHERE LastName = pLastName
            ";

        const string _QUERY_UPDATE_Person_BY_LastName =
            @"
                UPDATE Persons
                    SET LastName = pNewLastName , Tel = pNewTel , Address = pNewAddress
                    WHERE LastName = pOldLastName
            ";

        #endregion QUERIES\


        #region CRUD Methods

        public bool Insert(string pLastName, string pTel, string pAddress)
        {
            return base.insert(_QUERY_INSERT_Person,
                new OleDbParameter[]
                {
                    new OleDbParameter("pLastName",pLastName),
                    new OleDbParameter("pTel" , pTel),
                    new OleDbParameter("pAddress",pAddress)
                });
        }

        public dsPhonebook.PersonsDataTable Select_AllPersons()
        {
            return base.select_All(_QUERY_SELECTALL_Persons);
        }
        public dsPhonebook.PersonsDataTable Select_AllPersons_By_LastName(string pLastName)
        {
            return base.select_By(_QUERY_SELECTALL_Persons_BY_LastName,
                new OleDbParameter[] 
                {
                    new OleDbParameter ("pLastName" , pLastName)
                });
        }

        public bool Update_By_LastName(string pNewLastName , string pNewTel , string pNewAddress , string pOldLastName4Compare)
        {
            return base.update(_QUERY_UPDATE_Person_BY_LastName,
                new OleDbParameter[] 
                { 
                    new OleDbParameter("pNewLastName" , pNewLastName),
                    new OleDbParameter("pNewTel" , pNewTel),
                    new OleDbParameter("pNewAddress" , pNewAddress),
                    new OleDbParameter("pOldLastName" , pOldLastName4Compare)
                });
        }
        
        public bool Delete_By_LastName(string pLastName)
        {
            return base.delete(_QUERY_DELETE_Person_BY_LastName,
                new OleDbParameter[] 
                { 
                    new OleDbParameter("pLastName" , pLastName)
                });
        }
        
        #endregion CRUD Methods\
    }
}
