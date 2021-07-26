using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using Microsoft.AspNetCore.Identity;
using Portal.Core.Constants;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal
{
    public static class DbInitializer
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            if (!roleManager.Roles.Any())
                await SeedRoles(roleManager);

            if (!userManager.Users.Any())
                await SeedUsers(userManager);
        }


        public static void CreateDatabase(ExaLearnDbContext exaLearnDb)
        {
             exaLearnDb.Database.EnsureCreated();
        }

        private static async Task SeedUsers(UserManager<User> userManager)
        {
            var adminEmail = "adminexa@mailnesia.com";
            await userManager.CreateAsync(new User { UserName = adminEmail, Email = adminEmail, FirstName = "Peter", LastName = "Shilton" }, "_Test1234");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync(adminEmail), RoleNames.Admin);

            var coachEmail = "coachexa@mailnesia.com";
            await userManager.CreateAsync(new User { UserName = coachEmail, Email = coachEmail, FirstName = "Joe", LastName = "Hart" }, "_Test1234");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync(coachEmail), RoleNames.Coach);

            var hrEmail = "hrexa@mailnesia.com";
            await userManager.CreateAsync(new User { UserName = hrEmail, Email = hrEmail, FirstName = "David", LastName = "Seama" }, "_Test1234");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync(hrEmail), RoleNames.Hr);

            var userEmail = "userexa@mailnesia.com";
            await userManager.CreateAsync(new User { UserName = userEmail, Email = userEmail, FirstName = "Gordon", LastName = "Banks" }, "_Test1234");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync(userEmail), RoleNames.User);
        }

        private static async Task SeedRoles(RoleManager<IdentityRole<int>> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole<int>(RoleNames.Admin));
            await roleManager.CreateAsync(new IdentityRole<int>(RoleNames.Coach));
            await roleManager.CreateAsync(new IdentityRole<int>(RoleNames.Hr));
            await roleManager.CreateAsync(new IdentityRole<int>(RoleNames.User));
        }
    }
}
