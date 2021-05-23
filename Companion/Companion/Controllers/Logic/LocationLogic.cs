using Companion.Controllers.Logic.LogicInterface;
using Companion.Models.Context;
using Companion.Models.Entities;
using Companion.Models.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers.Logic
{
    public class LocationLogic : ILocation
    {
        private readonly UserManager<User> userManager;
        private readonly ApplicationContext context;

        public LocationLogic(UserManager<User> userManager, ApplicationContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }

        public Task AddLocation(Location location)
        {
            IRepository repository = new Repository(context, userManager);
            return repository.CreateLocation(location);
        }

        public List<Location> GetLocations()
        {
            IRepository repository = new Repository(context, userManager);
            return repository.GetLocations();
        }

        public Location GetLocation(int id)
        {
            IRepository repository = new Repository(context, userManager);
            return repository.GetLocation(id);
        }
    }
}
