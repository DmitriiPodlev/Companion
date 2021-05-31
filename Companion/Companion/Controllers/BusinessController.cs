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
using System.Reflection.Metadata.Ecma335;
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
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Start()
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            var model = repository.GetCategories();
            return View(model);
        }

        [HttpPost]
        public IActionResult Start(StartViewModel model)
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            repository.Start(model);
            return RedirectToAction("Information", "Business");
        }

        [HttpGet]
        public IActionResult Information()
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            var model = repository.GetInfo();
            return View(model);
        }

        [HttpPost]
        public IActionResult Information(InformationViewModel model)
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            repository.Information(model);
            return RedirectToAction("Locations", "Business");
        }

        [HttpGet]
        public IActionResult Locations()
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            var model = repository.GetLocations();
            return View(model);
        }

        [HttpPost]
        public IActionResult Locations(LocationsViewModel model)
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            repository.Locations(model);
            return RedirectToAction("Platform", "Business");
        }

        [HttpGet]
        public IActionResult Platform()
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            var model = repository.GetData();
            return View(model);
        }

        [HttpPost]
        public IActionResult Platform(PlatformViewModel model)
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            repository.Platform(model);
            return RedirectToAction("Pay", "Business");
        }


        [HttpGet]
        public IActionResult Pay()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Activities()
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

        [HttpGet]
        public IActionResult MyActivities()
        {
            IBusiness repository = new BusinessLogic(_userManager, context);
            var activities = repository.GetActivities();
            return View(activities);
        }
    }
}
