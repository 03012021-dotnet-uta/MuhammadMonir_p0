using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.DAL
{
    public interface ICustomerRepository 
    {
        List<Customer> GetCustomers();
        Customer GetCustomerByID(int customerId);
        
        void SaveCustomer(Customer customer);
    }
}
