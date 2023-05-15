namespace webapi.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public string companyName { get; set; }
        public string contactName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public Lead lead { get; set; }

        public Buyer() { }
        public Buyer(string companyName, string contactName, string password, string email, string phone_number, string city, string zip)
        {
            this.companyName = companyName;
            this.contactName = contactName;
            this.password = password;
            this.email = email;
            this.phone_number = phone_number;
            this.city = city;
            this.zip = zip;
        }




    }
}
