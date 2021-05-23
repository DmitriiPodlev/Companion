using Companion.Models.Entities;
using Companion.Views.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers.Logic.LogicInterface
{
    public interface IClient
    {
        public Task EditCient(EditViewModel model);
        List<Client> GetClients();
        Task DeleteClient(string id);
    }
}
