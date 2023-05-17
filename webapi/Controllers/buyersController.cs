using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class buyersController: ControllerBase
    {

        //Get all buyers from database   
        [HttpGet]
        public IEnumerable<Buyer> Get()
        {
            return new List<Buyer>
            {
                new Buyer
                {
                    Id = 1,
                    companyName = "Boca Code",
                    contactName = "Joe Doe",
                    email = ""
                }
            };
        }
    }
}
