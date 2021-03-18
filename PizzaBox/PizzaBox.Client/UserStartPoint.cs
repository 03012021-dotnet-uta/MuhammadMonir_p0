using PizzaBox.DAL;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Client
{
    class UserStartPoint
    {
        private ICustomerRepository customerRepository;
        public UserStartPoint()
        {
            customerRepository = new DBRepository();
        }
        public int WelcomeMessage()
        {
            List<Customer> customers = customerRepository.GetCustomers();
            Console.WriteLine("Good Day... Welcome to Pizza ordering App");
            Console.WriteLine("Enter your email:");
            string Email = Console.ReadLine();
            Customer customer = new Customer();
            try
            {
               customer = customers.First(cst => cst.Email.Contains(Email));
            }
            catch
            {

                Console.WriteLine("Sorry you are not registered... Please enter your name to register");
                customer.FName = Console.ReadLine();
                //customer.ID = totalcustomer + 1;
                customer.Email = Email;
                customerRepository.SaveCustomer(customer);
                return customer.ID;
            }

                            
           return customer.ID;
        }
    }
}
