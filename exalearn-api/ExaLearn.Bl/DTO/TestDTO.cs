using System.Collections.Generic;

namespace ExaLearn.Bl.DTO
{
    public class TestDTO
    {
        public int Id { get; set; }

        public List<AuditionQuestionDTO> GrammarQuestion { get; set; }

        public List<GrammarQuestionDTO> AuditionQuestion { get; set; }

        public string EssayTopic { get; set; }

        public string SpeakingTopic { get; set; }
    }
}
