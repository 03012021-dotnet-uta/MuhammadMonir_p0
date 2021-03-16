using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.DAL
{
    public class MockRepository : IRepository
    {

        public List<Customer> Customers { get; set; }
        public List<PremadePizza> PremadePizzas { get; set; }
        public List<CustomizedPizza> CustomizedPizzas { get; set; }
        public List<Crust> Crusts { get; set; }
        public List<Size> Sizes { get; set; }
        public List<Topping> Toppings { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Order> Orders { get; set; }
        public List<PizzaTopping> PizzaToppings { get; set; }

        public MockRepository()
        {
            Customers = new()
            {
                new Customer() { ID = 1, Name = "Customer 1", PhoneNumber = "0000000001", Address = "252 ABC" },
                new Customer() { ID = 2, Name = "Customer 2", PhoneNumber = "0000000002", Address = "131 DEF" },
                new Customer() { ID = 3, Name = "Customer 3", PhoneNumber = "0000000003", Address = "345 ZXC" },
                new Customer() { ID = 4, Name = "Customer 4", PhoneNumber = "0000000004", Address = "255 ABC" },
                new Customer() { ID = 5, Name = "Customer 5", PhoneNumber = "0000000005", Address = "258 ABC" }
            };

            Crusts = new()
            {
                new Crust() { ID = 1, Name = "Hand Tossed Crust", Description = "   ", BasePrice = 2f },
                new Crust() { ID = 2, Name = "Thin ‘N Crispy®", Description = "Our thinner crust is baked perfectly so you can taste more of your favorite toppings.", BasePrice = 3f },
                new Crust() { ID = 3, Name = "Original Stuffed Crust®", Description = " ", BasePrice = 4f },
                new Crust() { ID = 4, Name = "Heart-Shaped Pizza", Description = "The Heart-Shaped pizza is delivered unsliced in the shape of a heart. Available on Hand Tossed crust only. Additional charge for extra cheese, extra toppings and specialty pizzas.", BasePrice = 5f }

            };

            Sizes = new()
            {
                new Size() { ID = 1, Name = "Small", PriceMultiplicationFactor = 1f },
                new Size() { ID = 2, Name = "Medium", PriceMultiplicationFactor = 1.3f },
                new Size() { ID = 3, Name = "Large", PriceMultiplicationFactor = 1.4f },
                new Size() { ID = 4, Name = "X-Large", PriceMultiplicationFactor = 1.6f }

            };

            Toppings = new()
            {
                new Topping() { ID = 1, Name = "Pepperoni", BasePrice = 1.5f },
                new Topping() { ID = 2, Name = "Italian Sausage", BasePrice = 1.6f },
                new Topping() { ID = 3, Name = "Meatball", BasePrice = 1.7f },
                new Topping() { ID = 4, Name = "Grilled Chicken", BasePrice = 1.2f },
                new Topping() { ID = 5, Name = "Mushrooms", BasePrice = 1.4f },
                new Topping() { ID = 6, Name = "Red Onions", BasePrice = 1.4f },
                new Topping() { ID = 7, Name = "Beef", BasePrice = 44441.4f },
                new Topping() { ID = 8, Name = "Beef+", BasePrice = 201.4f }

            };

            PremadePizzas = new()
            {
                new PremadePizza() { ID = 1, Name = "Cheese Pizza", CrustID = 1 },
                new PremadePizza() { ID = 2, Name = "Pepperoni Pizza", CrustID = 1 },
                new PremadePizza() { ID = 3, Name = "Meat Lover's® Pizza", CrustID = 2 },
                new PremadePizza() { ID = 4, Name = "Supreme Pizza", CrustID = 2 },


            };

            OrderDetails = new List<OrderDetail>();
            Orders = new List<Order>();
            CustomizedPizzas = new List<CustomizedPizza>();

            PizzaToppings = new()
            {
                new PizzaTopping() { PremadePizzaID = 1, ToppingID = 1 },
                new PizzaTopping() { PremadePizzaID = 1, ToppingID = 2 },
                new PizzaTopping() { PremadePizzaID = 1, ToppingID = 3 },
                new PizzaTopping() { PremadePizzaID = 2, ToppingID = 4 },
                new PizzaTopping() { PremadePizzaID = 2, ToppingID = 5 },
                new PizzaTopping() { PremadePizzaID = 2, ToppingID = 6 },
                new PizzaTopping() { PremadePizzaID = 3, ToppingID = 4 },
                new PizzaTopping() { PremadePizzaID = 3, ToppingID = 1 },
                new PizzaTopping() { PremadePizzaID = 3, ToppingID = 2 },
                new PizzaTopping() { PremadePizzaID = 3, ToppingID = 4 },
                new PizzaTopping() { PremadePizzaID = 3, ToppingID = 6 },
                new PizzaTopping() { PremadePizzaID = 3, ToppingID = 7 },
                new PizzaTopping() { PremadePizzaID = 4, ToppingID = 3 },
                new PizzaTopping() { PremadePizzaID = 4, ToppingID = 5 },
                new PizzaTopping() { PremadePizzaID = 4, ToppingID = 1 }
            };
        }




        public void DeleteCustomer(int customerId)
        {
            Customers.Remove(
            Customers.Find(c => c.ID == customerId));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByID(int customerId)
        {
            return Customers.Find(c => c.ID == customerId);
        }

        public List<Customer> GetCustomers()
        {
           return Customers;
        }

        public void InsertCustomer(Customer customer)
        {
            Customers.Add(customer);
        }



        public List<PremadePizza> GetPremadePizzas()
        {
            return PremadePizzas;
        }

      
      

        public List<Crust> GetCrusts()
        {
           return Crusts;
        }

        public List<Topping> GetToppings()
        {
           return Toppings;
        }

        public List<Size> GetSizes()
        {
            return Sizes;
        }

        public List<Order> GetOrders()
        {
            return Orders;
        }

        public List<OrderDetail> GetOrderDetails()
        {
            return OrderDetails;
        }

        public void SaveCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void SaveOrder(Order o)
        {
            Orders.Add(o);
        }

        public void SaveOrderDetail(OrderDetail od)
        {
           OrderDetails.Add(od);
        }

        public void SaveCustomizedPizza(APizza cp)
        {
            CustomizedPizzas.Add((CustomizedPizza)cp);
            Console.WriteLine("Pizza saved...");
        }

        public List<CustomizedPizza> GetCustomizedPizzas()
        {
            return CustomizedPizzas;
        }

        public List<PizzaTopping> GetPremadePizzaTopping()
        {
            throw new NotImplementedException();
        }

        public List<PizzaTopping> GetCustomizedPizzaTopping()
        {
            throw new NotImplementedException();
        }
    }
}
