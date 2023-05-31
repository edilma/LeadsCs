using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Models;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class buyersController: ControllerBase
    {

        private LDSContext dbContext;

        public buyersController(LDSContext _dbContext)
        {
            dbContext = _dbContext;
        }

        //Get all buyers from database   
        [HttpGet]
        public IEnumerable<Buyer> Get()
        {
            List<Buyer> buyersList = dbContext.Buyers.ToList();
            return buyersList;
          
        }


        //Get buyer by id from the database
        [HttpGet("{id}")]
        public async Task<IResult> GetBuyerById(int id)
        {
            Buyer myBuyer = dbContext.Buyers.SingleOrDefault(x => x.Id == id);
            if (myBuyer == null)
            {
                return Results.NotFound();
            }
            else
            {
                return Results.Ok(myBuyer);
            }
            
        }

        // create a new buyer  
        [HttpPost]
        public async Task<IResult> AddBuyer([FromBody] Buyer buyer)
        {
            dbContext.Buyers.Add(buyer);
            dbContext.SaveChanges();

            return Results.Created("/Buyer", new Response { Message = "A buyer has been created" });
        }


    }
}
