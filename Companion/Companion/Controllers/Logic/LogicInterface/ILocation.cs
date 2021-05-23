using Companion.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers.Logic.LogicInterface
{
    public interface ILocation
    {
        Task AddLocation(Location location);
        List<Location> GetLocations();
        Location GetLocation(int id);
    }
}
