using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using System.Collections.Generic;


namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class leadsController : ControllerBase
    {
        //Get all leads from database   
        [HttpGet]
        public IEnumerable<Lead> Get()
        {
            return new List<Lead>
            {
                new Lead
                {
                    Id = 1,
                    first_name = "Joh55n",
                    last_name = "Doe",
                    email = ""
                }
            };
        }


        //Get a lead by id from the database
        [HttpGet("{id}")]
        public Lead GetLeadByLocation(int id)
        {

            return new Lead
            {
                Id = 1,
                first_name = "John",
                last_name = "Doe",
                email = "",
                learning_option = "remote"
            };
        }

        //Create a new lead and post it to the database
        //[HttpPost]
        //public Boolean Post([FromBody] Lead lead)
        //{

        //   // Console.WriteLine(lead.city);
        //    return true;

        //}

        // create a new lead  
        [HttpPost]
        public async Task<IResult> Post([FromBody] Lead lead)
        {
            // use the "lead" variable to write to the database
            //todo


            return Results.Created("/Leads", new Response { Message = "Hello" });
        }







    }
}

