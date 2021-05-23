using Companion.Controllers.Logic;
using Companion.Controllers.Logic.LogicInterface;
using Companion.Models.Context;
using Companion.Models.Entities;
using Companion.Views.Models.Business;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers
{
    public class BusinessController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationContext context;

        public BusinessController(UserManager<User> userManager, ApplicationContext context)
        {
            _userManager = userManager;
            this.context = context;
        }

        [HttpGet]
        public IActionResult Start()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Start(StartViewModel model)
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            repository.Start(model);
            return View(model);
        }

        [HttpGet]
        public IActionResult Information()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Information(InformationViewModel model)
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            repository.Information(model);
            return View(model);
        }

        [HttpGet]
        public IActionResult Locations()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Locations(LocationsViewModel model)
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            repository.Locations(model);
            return View(model);
        }

        [HttpGet]
        public IActionResult Platform()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Platform(PlatformViewModel model)
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            repository.Platform(model);
            return View(model);
        }


        [HttpGet]
        public IActionResult Pay()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Acitvities()
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            var activities = repository.GetActivities();
            return View(activities);
        }

        [HttpGet]
        public IActionResult Activity(int id)
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            var activity = repository.GetActivity(id);
            return View(activity);
        }
    }
}
