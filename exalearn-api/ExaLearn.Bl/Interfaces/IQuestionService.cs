using ExaLearn.Bl.DTO;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IQuestionService
    {
        Task<TestDTO> GenerateTestAsync(GenerateTestDTO generateTestDTO);
      
        Task<GrammarQuestionDTO> CreateGrammarQuestionAsync(GrammarQuestionDTO question);

        Task<AuditionQuestionDTO[]> CreateAudioQuestionAsync(AuditionQuestionDTO[] question);

        Task<TopicQuestionDTO[]> CreateTopicQuestionAsync(TopicQuestionDTO[] question);
    }
}
