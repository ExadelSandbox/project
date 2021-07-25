using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;
using System.Collections.Generic;

namespace ExaLearn.Bl.Mapping
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<Question, GrammarQuestionDTO>()
                .ForMember(g => g.Question, q => q.MapFrom(source => source.Text));

            CreateMap<List<GrammarQuestionDTO>, TestDTO>()
                .ForMember(t => t.GrammarQuestion, g => g.MapFrom(source => source));

            CreateMap<Question, AuditionQuestionDTO>()
                .ForMember(a => a.Question, q => q.MapFrom(source => source.Text))
                .ForMember(a => a.Url, q => q.MapFrom(source => source.AudioFile.Url));

            CreateMap<List<AuditionQuestionDTO>, TestDTO>()
                .ForMember(t => t.AuditionQuestion, a => a.MapFrom(source => source));
        }
    }
}