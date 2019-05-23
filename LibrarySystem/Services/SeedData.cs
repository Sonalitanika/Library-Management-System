using LibrarySystem.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Services
{
    public class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, string testUserPw)
        {
           using (var context=new LibrarySystemIdentityDbContext(serviceProvider.GetRequiredService<DbContextOptions<LibrarySystemIdentityDbContext>>()))
            {
                var adminID = await EnsureUserAsync(serviceProvider, testUserPw, "ubhaya123@gmail.com");
                await EnsureRole(serviceProvider, adminID, "Librarian");

            }
        }

        private static async Task<IdentityResult> EnsureRole(IServiceProvider serviceProvider, string adminID, string role)
        {
            IdentityResult IR;

            var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();
            if (!(await roleManager.RoleExistsAsync(role)))
            {
                IR = await roleManager.CreateAsync(new IdentityRole(role));
            }

            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

            var user = await userManager.FindByIdAsync(adminID);
            IR = await userManager.AddToRoleAsync(user, role);
            return IR;
        }

        private static async Task<string> EnsureUserAsync(IServiceProvider serviceProvider, string testUserPw, string userName)
        {
            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

            var user = await userManager.FindByNameAsync(userName);
            if (user == null)
            {
                user = new IdentityUser { UserName = userName, Email = userName };
                await userManager.CreateAsync(user, testUserPw);
            }

            return user.Id;
        }
    }
}
