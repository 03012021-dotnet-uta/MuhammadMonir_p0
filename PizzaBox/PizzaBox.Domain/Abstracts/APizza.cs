using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Abstracts
{
    public abstract class APizza
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CrustID { get; set; }

        public Crust Crust { get; set; }
      
    }
}
