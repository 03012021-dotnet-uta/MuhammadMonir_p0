using PizzaBox.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Models
{
    public class CustomizedPizza : APizza
    {
        public ICollection<CustomizedPizzaTopping> CustomizedPizzaToppings { get; set; } = new List<CustomizedPizzaTopping>();

    }
}
