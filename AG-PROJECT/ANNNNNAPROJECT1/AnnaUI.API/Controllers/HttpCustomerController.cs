using Microsoft.AspNetCore.Mvc;

namespace AnnaUI.API.Controllers
{
    public class HttpCustomerController : Controller
    {
        [ApiController]

        [Route("[Controller]")]
        public class CustomerController : ControllerBase
        {
            private readonly ICustomer customer;
            public CustomerController(ICustomer customer)
            {
                customer = customer;

            }

            [HttpPost] //post Everything on the customer Table
            public ActionResult PostCustomer(int customerID, string firstName, string lastName, string address, string city, string state, string zipcode)
            {
                //customerID,
                customer.SqlCustomerInformation(customerID, firstName, lastName, address, city, state, zipcode);
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
                return customer.SqlCustomerFullName(firstName, lastName);
            }




        }
    }
}