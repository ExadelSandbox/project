using ExaLearn.Bl.DTO;
using Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IQuestionService
    {
        public Task<GrammarQuestionDTO> CreateGrammarQuestionAsync(GrammarQuestionDTO question);

        public Task<AudioQuestionDTO> CreateAudioQuestionAsync(AudioQuestionDTO question);

        public Task<TopicQuestionDTO> CreateTopicQuestionAsync(TopicQuestionDTO question);

        public Task<List<QuestionDTO>> GetAllAsync();

        public Task<QuestionDTO> GetByIdAsync(int id);

        public Task<List<QuestionDTO>> GetByLevelAndTypeAsync(LevelType level, QuestionType type);

        public Task<QuestionDTO> UpdateAsync(QuestionDTO question);
    }
}
