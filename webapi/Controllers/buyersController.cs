using Microsoft.AspNetCore.Mvc;
using webapi.Data;
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

        //Get buyer by id from the database
        [HttpGet("{id}")]
        public Buyer GetBuyerById(int id)
        {
            return new Buyer
            {
                Id = 1,
                companyName = "Boca Code",
                contactName = "Joe Doe",
                email = "",
                phone_number = "555-555-5555",
                city = "Boca Raton",
                zip = "33431"
            };
        }

        // create a new buyer  
        [HttpPost]
        public async Task<IResult> AddBuyer([FromBody] Lead lead)
        {
            // use the "lead" variable to write to the database
            //todo


            return Results.Created("/Buyer", new Response { Message = "Hello" });
        }


    }
}
