using Shared.Enums;

namespace ExaLearn.Bl.DTO
{
    public class TopicQuestionDTO
    {
        public int Id { get; set; }

        public LevelType LevelType { get; set; }

        public QuestionType QuestionType { get; set; } = QuestionType.Topic;

        public string Topic { get; set; }
    }
}
