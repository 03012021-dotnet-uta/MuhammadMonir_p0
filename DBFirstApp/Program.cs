using System;
using DBFirstApp.Models;
using System.Collections.Generic;

namespace DBFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var dbcontext = new masterContext())
            {
                IEnumerable<Customer> customers = dbcontext.Customers;

                foreach(var c in customers)
                    System.Console.WriteLine(c.FirstName);
            }
        }
    }
}
