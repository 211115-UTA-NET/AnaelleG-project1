using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnaFarmerMarket.Data
{
    internal class CustomerFullInfo
    {

        private int _customerID;
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        private string _firstName= "";
        public string Firstname
        {
            get { return _firstName; }
            set { _firstName = value; }

        }

        private string _lastName = "";
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }

        }

        private string _address = "";
        public string Address
        {
            get { return _address; }
            set { _address = value; }

        }


        private string _city = "";
        public string City
        {
            get { return _city; }
            set { _city = value; }

        }

        private string _state = "";
        public string State
        {
            get { return _state; }
            set { _state = value; }

        }

        private int _zipCode = 0;
        public int Zipcode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

    }

}
