using ExaLearn.Bl.DTO;
using Shared.Enums;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IQuestionService
    {
        Task<TestDTO> GenerateTestAsync(LevelType level);
      
        Task<GrammarQuestionDTO> CreateGrammarQuestionAsync(GrammarQuestionDTO question);

        Task<AudioQuestionDTO> CreateAudioQuestionAsync(AudioQuestionDTO question);

        Task<TopicQuestionDTO> CreateTopicQuestionAsync(TopicQuestionDTO question);
    }
}
