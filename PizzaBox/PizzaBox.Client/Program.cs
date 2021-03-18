using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using PizzaBox.DAL;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;
using PizzaBox.Storing;

namespace PizzaBox.Client
{
    class Program
    {

        private static int customerId;
        private static int storeId;


        static void Main(string[] args)
        {
            char choice;
            do
            {
                //UserStartPoint usp = new();
                //customerId = usp.WelcomeMessage();
                //Console.WriteLine("UserID = {0}", customerId);
                //StoreSelector ss = new();
                //storeId = ss.SelectStore();
                //Console.WriteLine("You Selected {0} store", storeId);
                OrderTaker orderTaker = new();
                orderTaker.CreatPizza();//orderTaker.BuildOrder(1, 1); // (customerId, storeId);
                Console.WriteLine("\nThank you very much you order has been received. Store will contact you once your order is ready...");
                Console.WriteLine("\n\nPress <Enter> for new Order or <E> to exit");
                choice = Console.ReadKey().KeyChar;
               
            } while (choice != 'e' && choice != 'E');

            Console.WriteLine("\n\n\nBye---Thanks for using My App");
        }

        public static int multtest(int a, int b)
        {
            return a * b;
        }




    }
}
