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
        Task<IdentityResult> CreateUser(User user, string phone, string password = null);
        Task<User> FindUser(string userId);
        Task<Client> FindClient(string id);
        Task<IdentityResult> UpdateUser(User user);
        Task UpdateClient(Client client);
        Task<IdentityResult> DeleteUser(User user);
        Task<Client> FindUserByPhone(string phone);
        Task AddLogin(User user, ExternalLoginInfo info);
        List<Client> GetUsers();
        Task<User> GetUser(ClaimsPrincipal user);
        Task CreateActivity(Activity activity);
        int GetLastActivityId();
        Task UpdateActivity(Activity activity);
        Task DeleteAcivity(int id);
        Activity GetActivity(int id);
        List<Activity> GetActivities();
        Task CreateConfig(Config config);
        Task CreateService(Service service);
        Task CreateLocation(Location location);
        Location GetLocation(int id);
        List<Location> GetLocations();
        Task CreatePartner(Partner partner);
        List<Partner> GetPartners();
        Partner GetPartner(string text);
        Task CreateOrder(Order order);
        Order GetOrder(int id);
        List<Order> GetOrders();
        List<Order> GetOrdersByClientId(string id);
        Task DeleteOrder(int id);
    }
}
