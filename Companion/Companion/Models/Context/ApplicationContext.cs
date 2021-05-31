using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Companion.Models.Entities;

namespace Companion.Models.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Activity> Activity { get; set; }
        public DbSet<Config> Config { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Partner> Partner { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Order> Order { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
