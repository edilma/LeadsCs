using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Data
{
    public class LDSContext:DbContext
    {
        public DbSet<Lead> Leads { get; set; } = null!;
        public DbSet<Buyer> Buyers { get; set; } = null!; 
        
        public DbSet<LeadBuyer> LeadBuyers { get; set; } = null!;

  
        public LDSContext(DbContextOptions<LDSContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}
      