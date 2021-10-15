using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Employee(string name,string family )
        {
            this._firstName = name;
            this._lastName = family;
        }
    }
}
