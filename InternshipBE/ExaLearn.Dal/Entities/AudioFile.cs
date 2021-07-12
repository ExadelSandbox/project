using ExaLearn.Dal.Entities;

namespace ExaLearn.Dal.Model
{
    public class AudioFile
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int TestId { get; set; }

        public Test Test { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }
    }
}
