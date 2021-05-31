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
            var activity = new Activity
            {
                Id = model.Id,
                AboutActivity = model.AboutIt,
                Category = model.Category,
                Name = model.Name
            };
            return repository.CreateActivity(activity);
        }

        public StartViewModel GetCategories()
        {
            var list = new List<string>() { "банковские услуги", "продажа", "ремонт оборудования",
            "времяпрепровождение", "прочие услуги"};
            IRepository repository = new Repository(context, userManager);
            var id = repository.GetLastActivityId();
            return new StartViewModel { Id = id, Categories = list };
        }

        public InformationViewModel GetInfo()
        {
            IRepository repository = new Repository(context, userManager);
            var id = repository.GetLastActivityId();
            return new InformationViewModel { Id = id };
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

        public LocationsViewModel GetLocations()
        {
            IRepository repository = new Repository(context, userManager);
            var id = repository.GetLastActivityId();
            return new LocationsViewModel { Id = id };
        }

        public Task Locations(LocationsViewModel model)
        {
            var adreslist = model.Adres.Split(';').ToList();
            IRepository repository = new Repository(context, userManager);
            var activity = new Activity
            {
                Id = model.Id,
                PeriodOfWork = model.PeriodOfWork,
                Description = model.Description,
                Locations = adreslist
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

        public PlatformViewModel GetData()
        {
            IRepository repository = new Repository(context, userManager);
            var id = repository.GetLastActivityId();
            var list = new List<string>() { "google table", "excel", "bot" };
            return new PlatformViewModel { Forms = list, Id = id };
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
