using Farmer.Api.Dtos;
using Farmer.Api.Logic;

namespace Farmer.Api.Repository

{
    public interface ICustomer
    {

        Task<Customer> CreateAsync(Customer customer);// create new customer
        Task<bool> GetfirstandlastName(string? firstName, string? lastName); //To see if that is the customer name;
        Task<Customer> FindAsync(string? firstName, string? lastName);  //GET a customer




        //This is to see if the customer name is avaiable "Yes or No"
        //Task<bool>GetfirstandlastName(string? firstName, string? lastName);
        //Task<List<Customer>> GetName(string? firstName, string? lastName);

        ////the 2 below works
        //Task<List<Customer>> GetName(string? firstName, string? lastName); //to get the first and last name

        //Task<List<Customer>> SQLFullCustomerInfotoAdd(string? firstName, string? lastName, string? address, string? city, string? state, string? zipcode);


        // GET full/address or use it to to input it.

        //ask if they shop here before or i can ask for there name and use GET.
    }
}
