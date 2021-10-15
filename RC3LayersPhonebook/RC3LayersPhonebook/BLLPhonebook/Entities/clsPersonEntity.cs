using System;

namespace BLLBooks.Entities
{
    /// <summary>
    /// PersonEntity
    /// </summary>
    public class clsPersonEntity : clsBaseEntity
    {
        public clsPersonEntity()
        {

        }

        /// <summary>
        /// CopyConstructor
        /// </summary>
        /// <param name="pAnotherPerson"></param>
        public clsPersonEntity(clsPersonEntity pAnotherPerson)
        {
            LastName = pAnotherPerson.LastName;
            Tel= pAnotherPerson.Tel;
            Address= pAnotherPerson.Address;
        }

        #region Prop
        
        private string _lastName = string.Empty;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("LastName", "LastName is empty or null!");

                _lastName = value;
            }
        }

        private string _tel = string.Empty;
        public string Tel
        {
            get
            {
                return _tel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Tel", "Tel is empty or null!");

                _tel = value;
            }
        }

        public string Address
        {
            get;
            set;
        }

        #endregion Prop
    }
}
