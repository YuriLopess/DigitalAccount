using DigitalAccount.API.Models.AddCustomer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigitalAccount.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddCustomer(AddCustomerInput input)
        {
            return Created("", input);
        }
    }
}
