using Companion.Models.Context;
using Companion.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Companion.Models.Interface
{
    public class Repository
    {
        private readonly ApplicationContext db;
        private readonly UserManager<User> userManager;
        public Repository(ApplicationContext db, UserManager<User> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }

        public async Task<IdentityResult> CreateUser(User user, string password = null)
        {
            var result = await userManager.CreateAsync(user, password);
            return result;
        }

        public async Task<User> FindUser(string userId)
        {
            var result = await userManager.FindByIdAsync(userId);
            return result;
        }

        public async Task<IdentityResult> UpdateUser(User user)
        {
            var result = await userManager.UpdateAsync(user);
            return result;
        }

        public async Task<IdentityResult> DeleteUser(User user)
        {
            var result = await userManager.DeleteAsync(user);
            return result;
        }

        public async Task<User> FindUserByName(string name)
        {
            var user = await userManager.FindByNameAsync(name);
            return user;
        }

        public async Task AddLogin(User user, ExternalLoginInfo info)
        {
            await userManager.AddLoginAsync(user, info);
        }

        public List<User> GetUsers()
        {
            return userManager.Users.ToList();
        }

        public async Task<User> GetUser(ClaimsPrincipal user)
        {
            return await userManager.GetUserAsync(user);
        }

        public async Task CreateActivity(Activity activity)
        {
            db.Activity.Add(activity);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAcivity(int id)
        {
            var activity = db.Activity.Where(x => x.Id == id)
                .FirstOrDefault();
            db.Activity.Remove(activity);
            await db.SaveChangesAsync();
        }

        public Activity GetActivity(int id)
        {
            var activity = db.Activity.Where(x => x.Id == id)
                .FirstOrDefault();
            return activity;
        }

        public List<Activity> GetActivities()
        {
            return db.Activity.ToList();
        }

        public async Task CreateConfig(Config config)
        {
            db.Config.Add(config);
            await db.SaveChangesAsync();
        }

        public async Task CreateService(Service service)
        {
            db.Service.Add(service);
            await db.SaveChangesAsync();
        }

        public async Task CreateLocation(Location location)
        {
            db.Location.Add(location);
            await db.SaveChangesAsync();
        }

        public Location GetLocation(int id)
        {
            return db.Location.Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public List<Location> GetLocations()
        {
            return db.Location.ToList();
        }
    }
}
