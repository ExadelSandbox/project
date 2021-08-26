namespace ExaLearn.Bl.DTO
{
    public class TestDTO
    {
        public int PassedTestId { get; set; }

        public GrammarQuestionDTO[] GrammarQuestion { get; set; }

        public AuditionQuestionDTO[] AuditionQuestion { get; set; }

        public TopicQuestionDTO[] TopicQuestion { get; set; }
    }
}
