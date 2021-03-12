using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Singletons
{
    public class StoreSingleton
    {
        public List<AStore> stores = new List<AStore>();

        public StoreSingleton()
        {
            stores.Add(new Store1());
            stores.Add(new Store2());
        }
    }
}
