using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Client
{
    class StoreSelector
    {
        public static object StoreSingleton { get; private set; }

        public int SelectStore()
        {


            StoreSingleton ss = new();
            List<AStore> storeslist = ss.stores;
            //List<AStore> storeslist = ReadWriteXML.ReadStoreXML();
            foreach (var s in storeslist)
                Console.WriteLine("Please enter {0} if you want to select {1}", s.ID, s.Name);

            int i = Convert.ToInt32(Console.ReadLine());
            return i;
        }
    }
}
