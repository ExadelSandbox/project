using ExaLearn.Dal.Entities;

namespace ExaLearn.Dal.Model
{
    public class AudioFile
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int PassedTestId { get; set; }

        public PassedTest PassedTest { get; set; }

        public string Url { get; set; }
    }
}
