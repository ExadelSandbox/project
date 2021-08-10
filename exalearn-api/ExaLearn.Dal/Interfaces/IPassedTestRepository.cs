using ExaLearn.Dal.Entities;

namespace ExaLearn.Dal.Interfaces
{
    public interface IPassedTestRepository : IGenericRepository<PassedTest>
    {
        void ChangeStatus();
    }
}
