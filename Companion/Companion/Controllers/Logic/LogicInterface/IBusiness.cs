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
        StartViewModel GetCategories();
        Task Start(StartViewModel model);
        InformationViewModel GetInfo();
        Task Information(InformationViewModel model);
        LocationsViewModel GetLocations();
        Task Locations(LocationsViewModel model);
        Task Platform(PlatformViewModel model);
        PlatformViewModel GetData();
        List<Activity> GetActivities();
        Activity GetActivity(int id);
    }
}
