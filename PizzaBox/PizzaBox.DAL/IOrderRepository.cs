using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.DAL
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        List<OrderDetail> GetOrderDetails();
        int SaveOrder(Order o);
        void SaveOrderDetail(OrderDetail od);
    }
}
