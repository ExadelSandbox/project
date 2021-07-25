using System.Collections.Generic;

namespace ExaLearn.Bl.DTO
{
    public class TestDTO
    {
        public List<GrammarQuestionDTO> GrammarQuestion { get; set; }

        public List<AuditionQuestionDTO> AuditionQuestion { get; set; }

        public string EssayTopic { get; set; }

        public string SpeakingTopic { get; set; }
    }
}
