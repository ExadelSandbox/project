using Shared.Enums;

namespace ExaLearn.Dal.Entities
{
    public class EnglishLevel
    {
        public int Id { get; set; }

        public LevelType Level { get; set; }

        public string Description { get; set; }
    }
}
