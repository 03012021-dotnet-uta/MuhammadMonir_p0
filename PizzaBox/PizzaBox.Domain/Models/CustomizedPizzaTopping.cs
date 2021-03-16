using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Models
{
    
    public class CustomizedPizzaTopping
    {
        public int CustomizedPizzaID { get; set; }
        public CustomizedPizza PremadePizza{ get; set; }

        public int ToppingID { get; set; }
        public Topping Topping { get; set; }



    }
}
