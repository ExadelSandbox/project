using ExaLearn.Bl.Extensions;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExaLearn.Dal.Database
{
    public class ExaLearnDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public ExaLearnDbContext(DbContextOptions<ExaLearnDbContext> options) : base(options) { }

        public DbSet<AudioFile> FileEntries { get; set; }

        public DbSet<History> Histories { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }
    }
}
