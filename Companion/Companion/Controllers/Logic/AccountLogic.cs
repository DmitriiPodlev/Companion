using Companion.Controllers.Logic.LogicInterface;
using Companion.Models.Context;
using Companion.Models.Entities;
using Companion.Models.Interface;
using Companion.Views.Models.Login;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.IIS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers.Logic
{
    public class AccountLogic : IAccount
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly ApplicationContext context;

        public AccountLogic(UserManager<User> userManager, SignInManager<User> signInManager,
            ApplicationContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
        }

        public async Task<Client> Login(AccountModel model)
        {
            IRepository repository = new Repository(context, userManager);
            var client = await repository.FindUserByPhone(model.Phone);
            if (client != null)
                return client;
            else
            {
                var user = new User();
                await repository.CreateUser(user, model.Phone);
                return await repository.FindUserByPhone(model.Phone);
            }
        }

        public Partner LoginPartner(PartnerLogin model)
        {
            IRepository repository = new Repository(context, userManager);
            var partner = repository.GetPartner(model.AboutSelf);
            if (partner != null)
                return partner;
            else 
            {
                repository.CreatePartner(new Partner(model.AboutSelf));
                return repository.GetPartner(model.AboutSelf);
            }
        }
    }
}
