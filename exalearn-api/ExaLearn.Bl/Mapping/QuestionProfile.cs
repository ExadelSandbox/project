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
                .ForMember(g => g.Question, map => map.MapFrom(source => source.Text))
                .ForMember(g => g.Answers, map => map.MapFrom(source => source.Answers))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<List<GrammarQuestionDTO>, TestDTO>()
                .ForMember(t => t.GrammarQuestion, map => map.MapFrom(source => source))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<Question, AuditionQuestionDTO>()
                .ForMember(a => a.Question, map => map.MapFrom(source => source.Text))
                .ForMember(a => a.Url, map => map.MapFrom(source => source.AudioFile.Url))
                .ForMember(a => a.Answers, map => map.MapFrom(source => source.Answers))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<List<AuditionQuestionDTO>, TestDTO>()
                .ForMember(t => t.AuditionQuestion, map => map.MapFrom(source => source))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}