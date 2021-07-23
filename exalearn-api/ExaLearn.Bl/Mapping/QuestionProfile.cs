using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<Question, GrammarQuestionDTO>()
                .ForMember(g => g.Question, q => q.MapFrom(source => source.Text)).ReverseMap();

            CreateMap<GrammarQuestionDTO, TestDTO>()
                .ForMember(t => t.GrammarQuestion, g => g.MapFrom(source => source.Question)).ReverseMap();

            CreateMap<Question, AuditionQuestionDTO>()
                .ForMember(a => a.Question, q => q.MapFrom(source => source.Text))
                .ForMember(a => a.Url, q => q.MapFrom(source => source.AudioFile)).ReverseMap();

            CreateMap<AuditionQuestionDTO, TestDTO>()
                .ForMember(t => t.AuditionQuestion, a => a.MapFrom(source => source.Question))
                .ForMember(a => a.AuditionQuestion, q => q.MapFrom(source => source.Url)).ReverseMap();
        }
    }
}


//question => grammardto
//grammardto => testDto