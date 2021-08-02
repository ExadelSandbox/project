using ExaLearn.Bl.DTO;
using Shared.Enums;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IQuestionService
    {
        Task<TestDTO> GenerateTestAsync(LevelType level);
      
        Task<GrammarQuestionDTO> CreateGrammarQuestionAsync(GrammarQuestionDTO question);

        Task<AuditionQuestionDTO> CreateAudioQuestionAsync(AuditionQuestionDTO question);

        Task<TopicQuestionDTO> CreateTopicQuestionAsync(TopicQuestionDTO question);

        Task<PassedTestDTO> CreatePassedTestAsync(PassedTestDTO passedTestDTO);
    }
}
