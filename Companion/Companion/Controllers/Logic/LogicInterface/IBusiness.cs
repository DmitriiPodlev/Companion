using Companion.Models.Entities;
using Companion.Views.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Controllers.Logic.LogicInterface
{
    public interface IBusiness
    {
        Task Start(StartViewModel model);
        Task Information(InformationViewModel model);
        Task Locations(LocationsViewModel model);
        Task Platform(PlatformViewModel model);
        List<Activity> GetActivities();
        Activity GetActivity(int id);
    }
}
