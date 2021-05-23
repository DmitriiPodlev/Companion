using Companion.Controllers.Logic;
using Companion.Controllers.Logic.LogicInterface;
using Companion.Models.Context;
using Companion.Models.Entities;
using Companion.Views.Models.Client;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationContext context;
        private readonly UserManager<User> _userManager;

        public ClientController(UserManager<User> userManager, ApplicationContext context)
        {
            _userManager = userManager;
            this.context = context;
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(EditViewModel model)
        {
            IClient repository = new ClientLogic(context, _userManager);
            repository.EditCient(model);
            return View(model);
        }

        [HttpGet]
        public IActionResult Clients()
        {
            IClient repository = new ClientLogic(context, _userManager);
            var clients = repository.GetClients();
            return View(clients);
        }
    }
}
