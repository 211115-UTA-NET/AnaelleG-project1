using AnnaFarmerMarket.Data;
using Microsoft.AspNetCore.Mvc;

namespace project1.Controllers
{
    [ApiController]

    [Route("[Controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IOrder _order;
        public StoreController (IOrder order)
        {
            _order = order; 

        }
        
        [HttpPost]
        public ActionResult PostCustomer(int customerID, string firstName, string lastName, string address, string city, string state, int zipcode)
        {
            _order.SqlOrderInformation(customerID,firstName,lastName,address,city,state,zipcode);
            return StatusCode(200);

        }
    }
}
