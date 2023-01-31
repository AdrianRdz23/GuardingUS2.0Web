using GuardingUS2._0.Models;
using GuardingUS2._0.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace GuardingUS2._0.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Home> Homes { get; set; }
        public DbSet<Notification> Notification { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserNotification> UserNotifications { get; set; }

        public DbSet<Visitor> Visitors { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<IdentityRole> IdentityRoles { get; set; }

        public DbSet<IdentityUser> IdentityUsers { get; set; }

    }
}
