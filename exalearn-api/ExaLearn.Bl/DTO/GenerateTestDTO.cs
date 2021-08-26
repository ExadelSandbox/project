using ExaLearn.Shared.Enums;
using Shared.Enums;

namespace ExaLearn.Bl.DTO
{
    public class GenerateTestDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int? CheckerId { get; set; }

        public int? AssignTestId { get; set; }

        public LevelType LevelType { get; set; }

        public StatusType Status { get; set; } = StatusType.Active;
    }
}
