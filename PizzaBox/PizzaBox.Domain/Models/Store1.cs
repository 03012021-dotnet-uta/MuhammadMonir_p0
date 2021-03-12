using PizzaBox.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Models
{
    public class Store1 : AStore
    {
        public Store1()
        {
            StoreID = 1;
            Name = "Store#1";
        }
    }
}
