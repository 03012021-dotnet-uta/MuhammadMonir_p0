using PizzaBox.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Models
{
    public class PremadePizza : APizza
    {
       public ICollection<PremadePizzaTopping> PremadePizzaToppings { get; set; } = new List<PremadePizzaTopping>();

    }
}
