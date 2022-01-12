namespace Farmer.Api
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set;}

        public string State { get; set; }

        public string Zipcode { get; set; }



        public Customer(int customerID, string firstName, string lastName, string address, string city, string state, string zipcode)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zipcode = zipcode;


        }

       


    }
}
