namespace PizzaBox.Domain.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public string PhoneNumber { get; set; }
        public string Address {get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }


    }
    
}