
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Farmer.Api.Controllers;


// all my async stuff 
[Route("api/[controller]")]
[ApiController]


public class CustomerController : ControllerBase
{
    private readonly string _connectionString;
    public CustomerController(string connectString)
    {
        _connectionString = connectString;
    }


}

