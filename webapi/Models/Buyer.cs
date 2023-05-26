namespace webapi.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public string companyName { get; set; } = null!;
        public string contactName { get; set; } = null!;
        public string password { get; set; } = null!;   
        public string email { get; set; } = null!;
        public string phone_number { get; set; } = null!;
        public string? city { get; set; }
        public string? zip { get; set; }
       // public Lead Lead { get; set; }

        public Buyer() { }
        



    }
}
