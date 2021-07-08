using ExaLearn.Dal.Model;
using Microsoft.EntityFrameworkCore;

namespace ExaLearn.Dal.Database
{
    public class ExaLearnDbContext : DbContext
    {
        public DbSet<FileEntry> FileEntry { get; set; }

        public ExaLearnDbContext(DbContextOptions<ExaLearnDbContext> options) : base(options)
        {

        }
    }
}
