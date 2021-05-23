using Companion.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers.Logic.LogicInterface
{
    public interface IOrder
    {
        Task CreateOrder(Order order);
        Order GetOrder(int id);
        List<Order> GetOrders();
        List<Order> GetOrdersByClientId(string id);
    }
}
