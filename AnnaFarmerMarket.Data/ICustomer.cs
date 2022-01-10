using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnaFarmerMarket.Data
{
    public interface ICustomer
    {
        //task later

        //add this int customerID, to sqlorder
        void SqlCustomerInformation(int customerID,string firstName, string lastName, string address, string city, string state, int zipcode);
        List<string> SqlCustomerFullName(string firstName, string lastName);
    }


        





            
}
