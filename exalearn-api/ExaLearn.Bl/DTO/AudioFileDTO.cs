using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.DTO
{
    public class AudioFileDTO
    {
        public int Id { get; set; }

        public User User { get; set; }

        public Test Test { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }
    }
}
