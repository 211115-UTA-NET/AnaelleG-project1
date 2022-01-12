using Farmer.Api.Dtos;
using Farmer.Api;
using System;
using Microsoft.Data.SqlClient;

namespace Farmer.Api.App.UI
{
    public class CustomerAsyncAwait : ICustomer
    {
        private readonly string _connectionString;
        public CustomerAsyncAwait(string connectString)
        {
            _connectionString = connectString;


        }

        public Task<Customer> CreateAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> FindAsync(string? firstName, string? lastName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetfirstandlastName(string? firstName, string? lastName)
        {
            throw new NotImplementedException();
        }
    }
}
        //public Task<bool> GetfirstandlastName(string? firstName, string? lastName)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<Customer>> GetName(string? firstName, string? lastName)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<Customer>> SQLFullCustomerInfotoAdd(string? firstName, string? lastName, string? address, string? city, string? state, string? zipcode)
        //{
        //    throw new NotImplementedException();
        //}
 















        //get the full infor of the customer
        // public Task<List<Customer>> SQLFullCustomerInfotoAdd(string? firstName, string? lastName, string? address, string? city, string? state, string? zipcode)
        //        {
        //           // List<string> result = new List<string>();
        //            List<string> result = new List<string>();


//        using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
//            {
//                sqlConnection.Open();

//                using (SqlCommand sqlCommandFinder = new(
//                    "SELECT * FROM Customers WHERE FirstName=@firstname AND LastName=@lastname ", sqlConnection))
//                {
//                    // Finish command
//                    sqlCommandFinder.Parameters.AddWithValue("@firstname", firstName);
//                    sqlCommandFinder.Parameters.AddWithValue("@lastname", lastName);
//                    using (SqlDataReader reader = sqlCommandFinder.ExecuteReader())
//                    {
//                        // Use the reader to advance to the one record we want, or past it if there's no record
//                        if (reader.Read())
//                        {

//                            for (int i = 0; i < 7; i++)

//                            {

//                                object value = reader[i];

//                                result.Add(value == null ? "NULL" : value.ToString());
//                            }

//                        }

//                    }
//                }
//            }
//        return Task.FromResult<IAsyncEnumerable<Customer>>(out result);
//            //Task.FromResult<IAsyncEnumerable< Customer>>I;
//        }
//    }
//}

//icustomerRepo
//Task<bool> GetfirstandlastName(string? firstName, string? lastName);


////the 2 below works
//Task<List<Customer>> GetName(string? firstName, string? lastName); 
//to get the first and last name

//Task<List<Customer>> FullCustomerInfotoAdd(string? firstName, string? lastName,
//string? address, string? city, string? state, string? zipcode);


// public async Task<Customer>> GetfirstandlastName(string? firstName, string? lastName)