using System;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = WelcomeMessage();
            System.Console.WriteLine("You Are ... "+c.Name);
            //Store = SelectStore();
           // Pizza = SelectPizza();
           // Order = new Order(Store, Pizza);
        }

        public static Customer WelcomeMessage()
        {
            System.Console.WriteLine("Good Day... Welcome to Pizza ordering App");
            Customer c = new Customer();
            return c;
        }
    }
}
