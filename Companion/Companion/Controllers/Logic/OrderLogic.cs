using Companion.Controllers.Logic.LogicInterface;
using Companion.Models.Context;
using Companion.Models.Entities;
using Companion.Models.Interface;
using Companion.Views.Models.Order;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers.Logic
{
    public class OrderLogic : IOrder
    {
        private readonly UserManager<User> userManager;
        private readonly ApplicationContext context;

        public OrderLogic(UserManager<User> userManager, ApplicationContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }

        public CreateOrderViewModel GetModel(int id)
        {
            IRepository repository = new Repository(context, userManager);
            var activity = repository.GetActivity(id);
            return new CreateOrderViewModel { ActivityId = id, Adress = activity.PeriodOfWork,
            Name = activity.Name};
        }

        public Task CreateOrder(Order order)
        {
            IRepository repository = new Repository(context, userManager);
            return repository.CreateOrder(order);
        }

        public Order GetOrder(int id)
        {
            IRepository repository = new Repository(context, userManager);
            return repository.GetOrder(id);
        }

        public List<Order> GetOrders()
        {
            IRepository repository = new Repository(context, userManager);
            return repository.GetOrders();
        }

        public List<Order> GetOrdersByClientId(string id)
        {
            IRepository repository = new Repository(context, userManager);
            return repository.GetOrdersByClientId(id);
        }
    }
}
