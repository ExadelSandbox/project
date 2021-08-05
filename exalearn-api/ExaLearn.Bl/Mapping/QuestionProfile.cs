using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<GrammarQuestionDTO[], TestDTO>()
                .ForMember(t => t.GrammarQuestion, map => map.MapFrom(source => source))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<AuditionQuestionDTO[], TestDTO>()
                .ForMember(t => t.AuditionQuestion, map => map.MapFrom(source => source))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<TopicQuestionDTO[], TestDTO>()
                .ForMember(t => t.TopicQuestion, map => map.MapFrom(source => source[0]))
                .ForMember(t => t.TopicQuestion, map => map.MapFrom(source => source[1]))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<Question, GrammarQuestionDTO>()
                .ForMember(x => x.QuestionType, map => map.MapFrom(source => source.QuestionType))
                .ForMember(x => x.LevelType, map => map.MapFrom(source => source.LevelType))
                .ForMember(x => x.Question, map => map.MapFrom(source => source.Text))
                .ForMember(x => x.Answers, map => map.MapFrom(source => source.Answers))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<Question, AuditionQuestionDTO>()
                .ForMember(x => x.QuestionType, map => map.MapFrom(source => source.QuestionType))
                .ForMember(x => x.LevelType, map => map.MapFrom(source => source.LevelType))
                .ForMember(x => x.Url, map => map.MapFrom(source => source.FileUrl))
                .ForMember(x => x.Question, map => map.MapFrom(source => source.Text))
                .ForMember(x => x.Answers, map => map.MapFrom(source => source.Answers))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<Question, TopicQuestionDTO>()
                .ForMember(x => x.QuestionType, map => map.MapFrom(source => source.QuestionType))
                .ForMember(x => x.Topic, map => map.MapFrom(source => source.Text))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}