using System.Collections.Generic;

namespace ExaLearn.Dal.Entities
{
    public class UserTest
    {
        public int Id { get; set; }

        public List<Question> GrammarQuestions { get; set; }

        public List<Question> AuditionQuestions { get; set; }

        public List<Question> TopicsQuestions { get; set; }
    }
}
