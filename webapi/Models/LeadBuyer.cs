namespace webapi.Models
{
    public class LeadBuyer
    {
        public int Id { get; set; }
        public int LeadId { get; set; }
        public Lead Lead { get; set; } = null!;
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; } = null!;
    }
}
