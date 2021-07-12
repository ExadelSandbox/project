using ExaLearn.Dal.Entities;

namespace ExaLearn.Dal.Model
{
    public class FileEntry
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public Person PersonId { get; set; }

        public Test TestId { get; set; }

        public Question QuestionId { get; set; }

    }
}
