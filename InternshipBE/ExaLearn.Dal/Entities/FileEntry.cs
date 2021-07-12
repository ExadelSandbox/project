using ExaLearn.Dal.Entities;

namespace ExaLearn.Dal.Model
{
    public class FileEntry
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public User UserId { get; set; }

        public Test TestId { get; set; }

        public Question QuestionId { get; set; }

    }
}
