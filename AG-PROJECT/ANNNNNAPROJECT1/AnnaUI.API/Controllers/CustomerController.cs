using Microsoft.AspNetCore.Mvc;

namespace AnnaUI.API.Controllers
{
   
        [ApiController]

        [Route("[Controller]")]


    public class CustomerController : Controller
    {

        private readonly ICustomer _customer;
            public CustomerController(ICustomer customer)
            {
                _customer = customer;

            }

            [HttpPost] //post Everything on the customer Table
            public ActionResult PostCustomer(int customerID, string firstName, string lastName, string address, string city, string state, string zipcode)
            {
                //customerID,
                _customer.SqlCustomerInformation(customerID, firstName, lastName, address, city, state, zipcode);
                return StatusCode(200);

            }


            //[HttpGet]
            //public ActionResult FindCustomer(string firstName, string lastName)
            //{

            //    _customer.SqlCustomerFullName( firstName, lastName);

            //    return StatusCode(200);


            //}


            [HttpGet]
            public List<string> FindCustomer(string firstName, string lastName)
            {
                return _customer.SqlCustomerFullName(firstName, lastName);
            }

        }
    }


    



