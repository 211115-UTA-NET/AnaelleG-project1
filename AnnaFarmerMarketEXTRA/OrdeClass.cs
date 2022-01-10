using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnaFarmerMarket.Data
{
    public class OrderClass : IOrder
    {
        private readonly string _connectionString;
        public OrderClass(string connectString)
        {
            _connectionString = connectString;  
        }
        public void SqlOrderInformation(int customerID, string firstName, string lastName, string address, string city, string state, int zipcode)
        {
            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();
            using SqlCommand sqlCommand = new(@"INSERT INTO Customers (CustomerID, FirstName,LastName,Address,City,State,ZipCode)       
                    VALUES(@customerID, @firstname, @lastname, @address, @city, @state, @zipcode);", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@customerID", customerID);
            sqlCommand.Parameters.AddWithValue("@firstname", firstName);
            sqlCommand.Parameters.AddWithValue("@lastname", lastName);
            sqlCommand.Parameters.AddWithValue("@address", address);
            sqlCommand.Parameters.AddWithValue("@city", city);
            sqlCommand.Parameters.AddWithValue("@state", state);
            sqlCommand.Parameters.AddWithValue("@zipcode", zipcode);


            sqlCommand.ExecuteNonQuery();
            

            sqlConnection.Close();



                    
        }
    }
}
