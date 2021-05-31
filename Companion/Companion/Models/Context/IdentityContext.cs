using Companion.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Models.Context
{
    public class IdentityContext : IdentityDbContext<User>
    {
        public DbSet<Message> Messages { get; set; }
        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Message>()
                .HasOne(a => a.Sender)
                .WithMany(a => a.Messages)
                .HasForeignKey(a => a.UserId);
        }
    }
}
