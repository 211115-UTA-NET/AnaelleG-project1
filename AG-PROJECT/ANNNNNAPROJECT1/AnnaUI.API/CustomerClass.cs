using System.Data.SqlClient;

namespace AnnaUI.API
{

    public class CustomerClass : ICustomer
    {
        private readonly string _connectionString;
        public CustomerClass(string connectString)
        {
            _connectionString = connectString;
        }
        //int customerID, into sqlorder in add
        public void SqlCustomerInformation(int customerID, string firstName, string lastName, string address, string city, string state, string zipcode)
        {
            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();
            using SqlCommand sqlCommand = new(@"INSERT INTO Customers ( FirstName,LastName,Address,City,State,ZipCode)       
                    VALUES( @customerID,@firstname, @lastname, @address, @city, @state, @zipcode);", sqlConnection);

           // sqlCommand.Parameters.AddWithValue("@customerID", customerID);
            sqlCommand.Parameters.AddWithValue("@firstname", firstName);
            sqlCommand.Parameters.AddWithValue("@lastname", lastName);
            sqlCommand.Parameters.AddWithValue("@address", address);
            sqlCommand.Parameters.AddWithValue("@city", city);
            sqlCommand.Parameters.AddWithValue("@state", state);
            sqlCommand.Parameters.AddWithValue("@zipcode", zipcode);


            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();




        }


        //FIND A CUSTOMER
        public List<string> SqlCustomerFullName(string firstName, string lastName)
        {
            List<string> result = new List<string>();

            // Create (and later clean uo connection)
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                // Create and later close command
                using (SqlCommand sqlCommandFinder = new(
                    "SELECT * FROM Customers WHERE FirstName=@firstname AND LastName=@lastname ", sqlConnection))
                {
                    // Finish command
                    sqlCommandFinder.Parameters.AddWithValue("@firstname", firstName);
                    sqlCommandFinder.Parameters.AddWithValue("@lastname", lastName);

                    // Execute the command, which returns a reader with the cursor before the first record (and later clean up)
                    using (SqlDataReader reader = sqlCommandFinder.ExecuteReader())
                    {
                        // Use the reader to advance to the one record we want, or past it if there's no record
                        if (reader.Read())
                        {
                            // WE GOT A RECORD.  GET THE DATA AND RETURN THAT
                            //…GET LIST OF VALUES HERE…
                            //result = string[] {};
                            //it is going to get all the string in the record 
                            for (int i = 0; i < 7; i++)

                            {

                                //result.Add(reader[i].ToString());
                                //making sure it is not null
                                object value = reader[i];
                                // Possible null reference argument.
                                result.Add(value == null ? "NULL" : value.ToString());
                                // Possible null reference argument.


                            }


                        }

                    }
                }
            }
            return result;
        }
    }
}
