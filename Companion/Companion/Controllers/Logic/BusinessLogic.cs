using Companion.Controllers.Logic.LogicInterface;
using Companion.Models.Context;
using Companion.Models.Entities;
using Companion.Models.Interface;
using Companion.Views.Models.Business;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers.Logic
{
    public class BusinessLogic : IBusiness
    {
        private readonly UserManager<User> userManager;
        private readonly ApplicationContext context;

        public BusinessLogic(UserManager<User> userManager, ApplicationContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }

        public Task Start(StartViewModel model)
        {
            IRepository repository = new Repository(context, userManager);
            return repository.CreateActivity(new Activity
            {
                Id = model.Id,
                AboutActivity = model.AboutIt,
                Category = model.Category,
                Name = model.Name
            });
        }

        public Task Information(InformationViewModel model)
        {
            IRepository repository = new Repository(context, userManager);
            var activity = new Activity
            {
                Id = model.Id,
                Email = model.Email,
                WebSite = model.WebSite,
                Number = model.Number
            };
            return repository.UpdateActivity(activity);
        }

        public Task Locations(LocationsViewModel model)
        {
            IRepository repository = new Repository(context, userManager);
            var activity = new Activity
            {
                Id = model.Id,
                PeriodOfWork = model.PeriodOfWork,
                Description = model.Description,
                Locations = model.Adress
            };
            return repository.UpdateActivity(activity);
        }

        public Task Platform(PlatformViewModel model)
        {
            IRepository repository = new Repository(context, userManager);
            var activity = new Activity
            {
                Id = model.Id,
                Form = model.Form,
                Type = model.Type
            };
            return repository.UpdateActivity(activity);
        }

        public List<Activity> GetActivities()
        {
            IRepository repository = new Repository(context, userManager);
            return repository.GetActivities();
        }

        public Activity GetActivity(int id)
        {
            IRepository repository = new Repository(context, userManager);
            return repository.GetActivity(id);
        }
    }
}
