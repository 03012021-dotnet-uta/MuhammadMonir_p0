using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public Order Order { get; set; }
    }

    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int StoreID { get; set; }
        public float StoreAmount { get; set; }
        public float TaxAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
