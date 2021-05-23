using Companion.Models.Entities;
using Companion.Views.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers.Logic.LogicInterface
{
    public interface IAccount
    {
        Task<Client> Login(AccountModel model);
        Partner LoginPartner(PartnerLogin model);
    }
}
