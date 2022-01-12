namespace AnnaUI.API
{
    public interface ICustomer
    {

        //task later

        //add this int customerID, to sqlorder
        void SqlCustomerInformation(int customerID, string firstName, string lastName, string address, string city, string state, string zipcode);


        List<string> SqlCustomerFullName(string firstName, string lastName);

    }

}
