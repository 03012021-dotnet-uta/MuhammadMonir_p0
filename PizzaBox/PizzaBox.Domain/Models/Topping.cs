using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Models
{
    public class Topping
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float BasePrice { get; set; }

        public ICollection<PremadePizzaTopping>  PremadePizzaToppings { get; set; }
        public ICollection<CustomizedPizza> CustomizedPizzas { get; set; }

    }
}
