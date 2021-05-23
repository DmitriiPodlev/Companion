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
    public class LocationController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationContext context;

        public LocationController(UserManager<User> userManager, SignInManager<User> signInManager,
            ApplicationContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Location location)
        {
            ILocation repository = new LocationLogic(_userManager, context);
            repository.AddLocation(location);
            return RedirectToAction("/Home/Index");
        }

        [HttpGet]
        public IActionResult Location(int id)
        {
            ILocation repository = new LocationLogic(_userManager, context);
            var location = repository.GetLocation(id);
            return View(location);
        }

        [HttpGet]
        public IActionResult Locations()
        {
            ILocation repository = new LocationLogic(_userManager, context);
            var locations = repository.GetLocations();
            return View(locations);
        }
    }
}
