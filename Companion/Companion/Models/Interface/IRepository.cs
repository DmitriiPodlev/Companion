using Companion.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Companion.Models.Interface
{
    public interface IRepository
    {
        Task<IdentityResult> CreateUser(User user, string password = null);
        Task<User> FindUser(string userId);
        Task<IdentityResult> UpdateUser(User user);
        Task<IdentityResult> DeleteUser(User user);
        Task<User> FindUserByName(string name);
        Task AddLogin(User user, ExternalLoginInfo info);
        List<User> GetUsers();
        Task<User> GetUser(ClaimsPrincipal user);
        Task CreateActivity(Activity activity);
        Task DeleteAcivity(int id);
        Activity GetActivity(int id);
        List<Activity> GetActivities();
        Task CreateConfig(Config config);
        Task CreateService(Service service);
        Task CreateLocation(Location location);
        Location GetLocation(int id);
        List<Location> GetLocations();
    }
}
