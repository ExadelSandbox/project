using System.Collections.Generic;

namespace ExaLearn.Dal.Entities
{
    public class UserTest
    {
        public int Id { get; set; }

        public List<int> GrammarQuestions { get; set; } //do it in int

        public List<int> AuditionQuestions { get; set; }

        public List<int> TopicsQuestions { get; set; }
    }
}
