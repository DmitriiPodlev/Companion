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
    public class ChatController : Controller
    {
        private readonly IdentityContext _context;
        private readonly UserManager<User> _userManager;

        public ChatController(IdentityContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            //var chat = new Chat(_context, _userManager);
            //IChatController repository = new Factory<IChatController, Chat>(_logger, chat).Create();
            //var currentUser = await repository.GetUser(User);
            //ViewBag.CurrentUserName = currentUser.UserName;
            //var messages = await repository.GetMessages();

            //return View(messages);
            return View();
        }
        public async Task<IActionResult> Create(Message message)
        {
            //IError error = new Error();
            //var chat = new Chat(_context, _userManager);
            //IChatController repository = new Factory<IChatController, Chat>(_logger, chat).Create();
            //if (ModelState.IsValid)
            //{
            //    await repository.Messages(User, message);
            //    return Ok();
            //}
            //var model = error.GetError("Ошибка", "Не удалось отправить сообщение, возникла ошибка в базе данных");
            //return View("Error", model);
            return View();
        }
    }
}
