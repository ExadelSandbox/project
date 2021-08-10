namespace ExaLearn.Dal.Entities
{
    public class UserAnswer
    {
        public int Id { get; set; }

        public int PassedTestId { get; set; }

        public PassedTest PassedTest { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public int? ReportId { get; set; }

        public Report Report { get; set; }

        public string Answer { get; set; }

        public string FileUrl { get; set; }

        public int Assessment { get; set; }
    }
}
