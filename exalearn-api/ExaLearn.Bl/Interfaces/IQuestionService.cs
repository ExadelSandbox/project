using ExaLearn.Bl.DTO;
using Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IQuestionService
    {
        public Task<TestDTO> GenerateTest(LevelType level);
    }
}
