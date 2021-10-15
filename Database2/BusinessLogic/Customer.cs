using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Customer
    {
        private string _companyName;
        private string _city;
        private string _country;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public Customer(string companyName, string country, string city)
        {
            this._companyName = companyName;
            this._country = country;
            this._city = city;
        }
    }
}
