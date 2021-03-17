using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.DAL
{
    public class DBRepository : IRepository
    {
        private MyContext _myContext;

        public DBRepository()
        {
            MyContext myContext = new();
            _myContext = myContext;
        }

        public List<Crust> GetCrusts()
        {
            return _myContext.Crusts.ToList<Crust>();
        }

        public Customer GetCustomerByID(int customerId)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            return _myContext.Customers.ToList<Customer>();
        }

        public List<CustomizedPizza> GetCustomizedPizzas()
        {
            throw new NotImplementedException();
        }

        public List<CustomizedPizzaTopping> GetCustomizedPizzaTopping()
        {
            return _myContext.CustomizedPizzaTopping.ToList<CustomizedPizzaTopping>();

        }

        public List<OrderDetail> GetOrderDetails()
        {
            return _myContext.OrderDetails.ToList<OrderDetail>();
        }

        public List<Order> GetOrders()
        {
            return _myContext.Orders.ToList<Order>();
        }

        public List<PremadePizza> GetPremadePizzas()
        {
            return _myContext.PremadePizzas.ToList<PremadePizza>();
        }

        public List<PremadePizzaTopping> GetPremadePizzaTopping()
        {
            return _myContext.PremadePizzaTopping.ToList<PremadePizzaTopping>();

        }

        public List<Size> GetSizes()
        {
            return _myContext.Sizes.ToList<Size>();
        }

        public List<Topping> GetToppings()
        {
            return _myContext.Toppings.ToList<Topping>(); 
        }

        public List<OrderDetail> OrderDetails()
        {
            return _myContext.OrderDetails.ToList<OrderDetail>();
        }

        public void SaveCustomer(Customer customer)
        {
            _myContext.Customers.Add(customer);
            _myContext.SaveChanges();
        }

        public int SaveCustomizedPizza(APizza cp)
        {
            _myContext.CustomizedPizzas.Add((CustomizedPizza)cp);
            _myContext.SaveChanges();
            return cp.ID;
        }

        public int SaveOrder(Order o)
        {
            _myContext.Orders.Add(o);
            _myContext.SaveChanges();
            return o.ID;
        }

        public void SaveOrderDetail(OrderDetail od)
        {
            _myContext.OrderDetails.Add(od);
            _myContext.SaveChanges();
        }

      
    }
}
