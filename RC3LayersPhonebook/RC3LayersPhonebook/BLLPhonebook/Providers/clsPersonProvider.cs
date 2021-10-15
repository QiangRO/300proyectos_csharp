using System;
using System.Collections.Generic;
using BLLBooks.Entities;
using DALPhonebook.Adapters;

namespace BLLBooks.Providers
{
    public class clsPersonProvider: IProvider<clsPersonEntity,string>
    {
        private clsPersonAdapter _personAdapter ;

        public clsPersonProvider()
        {
            _personAdapter = new clsPersonAdapter();
        }

        #region IProvider<clsPersonEntity> Members

        public bool Add(clsPersonEntity pPerson4Add)
        {
            return _personAdapter.Insert(pPerson4Add.LastName, pPerson4Add.Tel, pPerson4Add.Address);
        }

        public bool Update(clsPersonEntity pPerson4Update, string pLastName4Compare)
        {
            return _personAdapter.Update_By_LastName(pPerson4Update.LastName, pPerson4Update.Tel, pPerson4Update.Address, pLastName4Compare);
        }

        public bool Delete(string pLastName4Compare)
        {
            return _personAdapter.Delete_By_LastName(pLastName4Compare);
        }

        public List<clsPersonEntity> Get_All_Items()
        {
            List<clsPersonEntity> retList = new List<clsPersonEntity>();

            //casting to the List<clsPersonEntity>
            foreach (var person in _personAdapter.Select_AllPersons())
            {
                retList.Add(new clsPersonEntity()
                {
                    LastName = person.lastName,
                    Tel = person.tel,
                    Address = person.address
                });
            }
            
            return retList;
        }
        public List<clsPersonEntity> Get_Items_By_LastName(string pLastName)
        {
            List<clsPersonEntity> retList = new List<clsPersonEntity>();

            //casting to the List<clsPersonEntity>
            foreach (var person in _personAdapter.Select_AllPersons_By_LastName(pLastName))
            {
                retList.Add(new clsPersonEntity()
                {
                    LastName = person.lastName,
                    Tel = person.tel,
                    Address = person.address
                });
            }

            return retList;
        }


        #endregion
    }
}
