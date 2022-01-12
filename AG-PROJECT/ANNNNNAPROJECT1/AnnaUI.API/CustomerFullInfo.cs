namespace AnnaUI.API
{
    public class CustomerFullInfo
    {

        private int customerID;
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        private string firstName = "";
        public string Firstname
        {
            get { return firstName; }
            set { firstName = value; }

        }

        private string lastName = "";
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }

        }

        private string address = "";
        public string Address
        {
            get { return address; }
            set { address = value; }

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

        private string _zipCode = "";
        public string Zipcode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

    }
}
