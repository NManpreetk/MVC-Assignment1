namespace Assignment1.Migrations
{
    using Assignment1.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
            }
            
            ApplicationUser adminUser = null;
            if (!context.Users.Any(p => p.UserName == "admin@myapp.com"))
            {
                adminUser = new ApplicationUser();
                adminUser.UserName = "admin@myapp.com";
                adminUser.Email = "admin@myapp.com";
                adminUser.FirstName = "Admin";
                adminUser.LastName = "User";
                userManager.Create(adminUser, "Pass-Word!");
            }
            else
            {
                adminUser = context.Users.Where(p => p.UserName == "admin@myapp.com")
                    .FirstOrDefault();
            }
            
            if (!userManager.IsInRole(adminUser.Id, "Admin"))
            {
                userManager.AddToRole(adminUser.Id, "Admin");
            }
        }
    }
}
