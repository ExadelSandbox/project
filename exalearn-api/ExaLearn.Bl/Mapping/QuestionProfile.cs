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
                .ForMember(g => g.Question, q => q.MapFrom(source => source.Text))
                .ForMember(g => g.Answers, q => q.MapFrom(source => source.Answers));

            CreateMap<List<GrammarQuestionDTO>, TestDTO>()
                .ForMember(t => t.GrammarQuestion, g => g.MapFrom(source => source))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<Question, AuditionQuestionDTO>()
                .ForMember(a => a.Question, q => q.MapFrom(source => source.Text))
                .ForMember(a => a.Url, q => q.MapFrom(source => source.AudioFile.Url))
                .ForMember(a => a.Answers, q => q.MapFrom(source => source.Answers));

            CreateMap<List<AuditionQuestionDTO>, TestDTO>()
                .ForMember(t => t.AuditionQuestion, a => a.MapFrom(source => source))
                .ForAllOtherMembers(x => x.Ignore());

        }
    }
}