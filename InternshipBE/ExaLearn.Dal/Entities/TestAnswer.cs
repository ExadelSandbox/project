namespace ExaLearn.Dal.Entities
{
    public class TestAnswer
    {
        public int Id { get; set; }

        public int TestId { get; set; }

        public Test Test { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public string Answer { get; set; }

        public int Assessment { get; set; }
    }
}
