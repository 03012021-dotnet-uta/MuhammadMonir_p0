using System;
using DBFirstApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace DBFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var dbcontext = new masterContext())
            {
                List<Customer> customers = dbcontext.Customers.ToList();

                foreach(var c in customers)
                    System.Console.WriteLine(c.FirstName);
            }
        }
    }
}
