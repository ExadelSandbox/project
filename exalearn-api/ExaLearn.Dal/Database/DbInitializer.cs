using ExaLearn.Dal.Database;

namespace ExaLearn.Dal
{
    public static class DbInitializer
    {
        public static void DbInitialize(ExaLearnDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
        }
    }
}
