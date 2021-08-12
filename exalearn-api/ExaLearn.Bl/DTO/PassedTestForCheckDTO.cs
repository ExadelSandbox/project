using ExaLearn.Shared.Enums;
using Shared.Enums;

namespace ExaLearn.Bl.DTO
{
    public class PassedTestForCheckDTO
    {
        public int Id { get; set; }

        public LevelType LevelType { get; set; }

        public int Assessment { get; set; }

        public StatusType Status { get; set; }

        public TestDTO UserTest { get; set; }

        public UserAnswerDTO[] UserAnswers { get; set; }
    }
}