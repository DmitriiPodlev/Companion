using Companion.Controllers.Logic.LogicInterface;
using Companion.Models.Context;
using Companion.Models.Entities;
using Companion.Models.Interface;
using Companion.Views.Models.Client;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers.Logic
{
    public class ClientLogic : IClient
    {
        private readonly ApplicationContext context;
        private readonly UserManager<User> userManager;

        public ClientLogic(ApplicationContext context, UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public Task EditCient(EditViewModel model)
        {
            IRepository repository = new Repository(context, userManager);
            var client = new Client(model.Id, model.Phone, model.FirstName, model.SecondName, 
                model.Language, model.Notifications);
            return repository.UpdateClient(client);
        }

        public List<Client> GetClients()
        {
            IRepository repository = new Repository(context, userManager);
            return repository.GetUsers();
        }

        public async Task DeleteClient(string id)
        {
            IRepository repository = new Repository(context, userManager);
            var user = await repository.FindUser(id);
            await repository.DeleteUser(user);
        }
    }
}
