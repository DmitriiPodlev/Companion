using Companion.Controllers.Logic;
using Companion.Controllers.Logic.LogicInterface;
using Companion.Models.Context;
using Companion.Models.Entities;
using Companion.Views.Models.Login;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationContext context;
        
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager,
            ApplicationContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.context = context;
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AccountModel model)
        {
            IAccount repository = new AccountLogic(_userManager, _signInManager, context);
            repository.Login(model);
            return View(model);
        }

        [HttpGet]
        public IActionResult LoginPartner()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPartner(PartnerLogin model)
        {
            IAccount repository = new AccountLogic(_userManager, _signInManager, context);
            repository.LoginPartner(model);
            return View(model);
        }
    }
}
