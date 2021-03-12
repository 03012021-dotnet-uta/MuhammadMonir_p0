using PizzaBox.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Models
{
    public class Store2 : AStore
    {
        public Store2()
        {
            StoreID = 2;
            Name = "Store#2";
        }
    }
}
