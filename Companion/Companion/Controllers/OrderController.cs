using Companion.Controllers.Logic;
using Companion.Controllers.Logic.LogicInterface;
using Companion.Models.Context;
using Companion.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationContext context;
        private readonly UserManager<User> _userManager;

        public OrderController(UserManager<User> userManager, ApplicationContext context)
        {
            _userManager = userManager;
            this.context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            IOrder repository = new OrderLogic(_userManager, context);
            repository.CreateOrder(order);
            return RedirectToAction("/Home/Index");
        }

        [HttpGet]
        public IActionResult Orders()
        {
            IOrder repository = new OrderLogic(_userManager, context);
            var orders = repository.GetOrders();
            return View(orders);
        }

        [HttpGet]
        public IActionResult MyOrders(string id)
        {
            IOrder repository = new OrderLogic(_userManager, context);
            var orders = repository.GetOrdersByClientId(id);
            return View(orders);
        }

        [HttpGet]
        public IActionResult Information(int id)
        {
            IOrder repository = new OrderLogic(_userManager, context);
            var order = repository.GetOrder(id);
            return View(order);
        }
    }
}
