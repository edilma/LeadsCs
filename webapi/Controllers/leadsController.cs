using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using System.Collections.Generic;
using webapi.Data;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class leadsController : ControllerBase
    {
        private LDSContext dbContext;
        
        public leadsController(LDSContext _dbContext)
        {
            dbContext = _dbContext;

        }


        //Get all leads from database   
        [HttpGet]
        public IEnumerable<Lead> Get()
        {

           //get all leads from the database dbcontext and return them as a list of leads
           List<Lead> theLeads = dbContext.Leads.ToList();
            return theLeads;

        }
        
        //Get leads by learning option ning  from database

        [HttpGet ("{learning_option}")]

        public IEnumerable<Lead> GetLeadsByLearningOption(string learning_option)
        {
            //get all leads from the database dbcontext and return them as a list of leads
            List<Lead> theLeads = dbContext.Leads.Where(x => x.learning_option == learning_option).ToList();
            return theLeads;
        }





        //Get a lead by id from the database
        [HttpGet("{id}")]
        public async Task<IResult> GetLeadByLocation(int id)
        {
            Lead myLead =  dbContext.Leads.SingleOrDefault(x => x.Id == id);
            if (myLead == null)
            {
                return Results.NotFound();
            }
            else
            {
                return Results.Ok(myLead);
            }

        }


        // create a new lead  
        [HttpPost]
        public async Task<IResult> Post([FromBody] Lead lead)
        {
            // use the "lead" variable to write to the database
            dbContext.Leads.Add(lead);
            dbContext.SaveChanges();
          
            return Results.Created("/Leads", new Response { Message = "Lead Added " });
        }







    }
}

