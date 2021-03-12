using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;
using PizzaBox.Storing;

namespace PizzaBox.Client
{
    class Program
    {
        public static object StoreSingleton { get; private set; }

        static void Main(string[] args)
        {
            Customer c = WelcomeMessage();
            System.Console.WriteLine("You Are ... "+c.Name);
            AStore selectedStore = SelectStore();
            Console.WriteLine("You Selected {0} store", selectedStore.Name);
            // Pizza = SelectPizza();
            // Order = new Order(Store, Pizza);
            ReadWriteXML.ReadStoreXML();
        }

        private static AStore SelectStore()
        {


            StoreSingleton ss = new StoreSingleton();
            List<AStore> storeslist = ss.stores;
            foreach(var s in storeslist)
                Console.WriteLine("Please enter {0} if you want to select {1}",s.StoreID,s.Name);
           
            int i = Convert.ToInt32(Console.ReadLine());
            return storeslist[i-1];
        }

        public static Customer WelcomeMessage()
        {
            System.Console.WriteLine("Good Day... Welcome to Pizza ordering App");
            Customer c = new Customer();
            return c;
        }
    }
}
