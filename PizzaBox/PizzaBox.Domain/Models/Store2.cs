using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Store2 : AStore
    {
        public string Title { get; set; }
        public Store2()
        {
            ID = 2;
            Name = "Store#2";
            Title = "A Franchise Sereze";
        }
    }
}
