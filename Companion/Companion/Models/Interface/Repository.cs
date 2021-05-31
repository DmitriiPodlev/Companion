using Companion.Models.Context;
using Companion.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Companion.Models.Interface
{
    public class Repository : IRepository
    {
        private readonly ApplicationContext db;
        private readonly UserManager<User> userManager;
        public Repository(ApplicationContext db, UserManager<User> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }

        public async Task<IdentityResult> CreateUser(User user, string phone, string password = "password")
        {
            var result = await userManager.CreateAsync(user, password);
            var client = new Client(user.Id, phone, null, null, "русский", true);
            db.Client.Add(client);
            db.SaveChanges();
            return result;
        }

        public async Task<User> FindUser(string userId)
        {
            var result = await userManager.FindByIdAsync(userId);
            return result;
        }

        public async Task<Client> FindClient(string id)
        {
            return await db.Client.FindAsync(id);
        }

        public async Task<IdentityResult> UpdateUser(User user)
        {
            var result = await userManager.UpdateAsync(user);
            return result;
        }

        public async Task UpdateClient(Client client)
        {
            db.Client.Update(client);
            await db.SaveChangesAsync();
        }

        public async Task<IdentityResult> DeleteUser(User user)
        {
            var result = await userManager.DeleteAsync(user);
            var client = db.Client.Find(user.Id);
            db.Client.Remove(client);
            db.SaveChanges();
            return result;
        }

        public async Task AddLogin(User user, ExternalLoginInfo info)
        {
            await userManager.AddLoginAsync(user, info);
        }

        public async Task<Client> FindUserByPhone(string phone)
        {
            var user = await db.Client.Where(x => x.Phone == phone)
                .FirstOrDefaultAsync();
            return user;
        }

        public List<Client> GetUsers()
        {
            return db.Client.ToList();
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

        public int GetLastActivityId()
        {
            var activity = db.Activity.ToList().LastOrDefault();
            if (activity == null)
                return 1;
            else
            {
                var id = activity.Id + 1;
                return id;
            }
        }

        public async Task UpdateActivity(Activity activity)
        {
            db.Activity.Update(activity);
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

        public async Task CreatePartner(Partner partner)
        {
            db.Partner.Add(partner);
            await db.SaveChangesAsync();
        }

        public List<Partner> GetPartners()
        {
            return db.Partner.ToList();
        }

        public Partner GetPartner(string text)
        {
            var parnter = db.Partner.Where(x => x.Information == text)
                .FirstOrDefault();
            return parnter;
        }

        public async Task CreateOrder(Order order)
        {
            db.Order.Add(order);
            await db.SaveChangesAsync();
        }

        public Order GetOrder(int id)
        {
            return db.Order.Find(id);
        }

        public List<Order> GetOrders()
        {
            return db.Order.ToList();
        }
        
        public List<Order> GetOrdersByClientId(string id)
        {
            var orders = db.Order.Where(x => x.ClientId == id)
                .ToList();
            return orders;
        }

        public async Task DeleteOrder(int id)
        {
            var order = db.Order.Find(id);
            db.Order.Remove(order);
            await db.SaveChangesAsync();
        }
    }
}
