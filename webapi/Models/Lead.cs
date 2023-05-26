namespace webapi.Models
{
    public class Lead
    {
        public int Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; } 
        public string email { get; set; }
        public string phone_number { get; set; }
        public string  city { get; set; }
        public string state { get; set; }
        public string zip { get; set; } 
        public string? gender { get; set; }

        public string learning_option { get; set; }
        public bool agree { get; set; }
     

        public Lead() { }
        
        
        


    }
}
