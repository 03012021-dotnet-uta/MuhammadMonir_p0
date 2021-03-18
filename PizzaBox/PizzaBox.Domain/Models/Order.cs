using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public enum OrderStatus
    { Delivered = 1, Received, InProgress, Cancelled }

    public class OrderDetail
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int PremadePizzaID { get; set; }
        public PremadePizza PremadePizza { get; set; }
        public int CustomizedPizzaID { get; set; }
        public CustomizedPizza CustomizedPizza { get; set; }
        public string ProductName { get; set; }
        public int SizeID { get; set; }
        public Size Size { get; set; }

        public int Quantity { get; set; }
        public float Price { get; set; }
        public Order Order { get; set; }
    }

    public class Order
    {
       
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int StoreID { get; set; }
        public Store Store { get; set; }
        public float StoreAmount { get; set; }
        public float TaxAmount { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
