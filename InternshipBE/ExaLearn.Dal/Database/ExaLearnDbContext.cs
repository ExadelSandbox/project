using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExaLearn.Dal.Database
{
    public class ExaLearnDbContext : IdentityDbContext<ApplicationUser>
    {
        public ExaLearnDbContext(DbContextOptions<ExaLearnDbContext> options) : base(options)
        {

        }

        public DbSet<FileEntry> FileEntry { get; set; }
    }
}
