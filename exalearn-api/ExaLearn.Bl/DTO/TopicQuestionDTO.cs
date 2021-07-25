using Shared.Enums;

namespace ExaLearn.Bl.DTO
{
    public class TopicQuestionDTO
    {
        public int Id { get; set; }

        public LevelType Level { get; set; }

        public string Topic { get; set; }
    }
}
