using ExaLearn.Dal.Entities;
using Microsoft.AspNetCore.Identity;
using Portal.Core.Constants;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal
{
    public static class DbInitializer
    {
        public static async Task Seed(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            if (!roleManager.Roles.Any())
                await SeedRoles(roleManager);

            if (!userManager.Users.Any())
                await SeedUsers(userManager);
        }

        public static async Task SeedUsers(UserManager<ApplicationUser> userManager)
        {
            var adminEmail = "adminexa@mailnesia.com";
            await userManager.CreateAsync(new ApplicationUser { UserName = adminEmail, Email = adminEmail, FirstName = "admin", LastName = "Exa" }, "_Test1234");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync(adminEmail), RoleNames.Admin);

            var coachEmail = "coachexa@mailnesia.com";
            await userManager.CreateAsync(new ApplicationUser { UserName = coachEmail, Email = coachEmail, FirstName = "coach", LastName = "Exa" }, "_Test1234");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync(coachEmail), RoleNames.Coach);

            var hrEmail = "hrexa@mailnesia.com";
            await userManager.CreateAsync(new ApplicationUser { UserName = hrEmail, Email = hrEmail, FirstName = "hr", LastName = "Exa" }, "_Test1234");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync(hrEmail), RoleNames.Hr);

            var userEmail = "userexa@mailnesia.com";
            await userManager.CreateAsync(new ApplicationUser { UserName = userEmail, Email = userEmail, FirstName = "user", LastName = "Exa" }, "_Test1234");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync(userEmail), RoleNames.User);
        }

        public static async Task SeedRoles(RoleManager<IdentityRole<int>> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole<int>(RoleNames.Admin));
            await roleManager.CreateAsync(new IdentityRole<int>(RoleNames.Coach));
            await roleManager.CreateAsync(new IdentityRole<int>(RoleNames.Hr));
            await roleManager.CreateAsync(new IdentityRole<int>(RoleNames.User));
        }
    }
}
