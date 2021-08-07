using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<GrammarQuestionDTO[], UserTest>()
                .ForMember(t => t.GrammarQuestions, map => map.MapFrom(source => source))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<AuditionQuestionDTO[], UserTest>()
                .ForMember(t => t.AuditionQuestions, map => map.MapFrom(source => source))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<TopicQuestionDTO[], UserTest>()
                .ForMember(t => t.TopicsQuestions, map => map.MapFrom(source => source))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<UserTest, PassedTest>()
                .ForMember(t => t.UserTestId, map => map.MapFrom(source => source.Id))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<GenerateTestDTO, PassedTest>()
                .ForMember(t => t.UserId, map => map.MapFrom(source => source.UserId))
                .ForMember(t => t.CheckerId, map => map.MapFrom(source => source.CheckerId))
                .ForMember(t => t.AssignTestId, map => map.MapFrom(source => source.AssignTestId))
                .ForMember(t => t.LevelType, map => map.MapFrom(source => source.LevelType))
                .ForMember(t => t.Status, map => map.MapFrom(source => source.Status))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<UserTest, TestDTO>()
                .ForMember(t => t.GrammarQuestion, map => map.MapFrom(source => source.GrammarQuestions))
                .ForMember(t => t.AuditionQuestion, map => map.MapFrom(source => source.AuditionQuestions))
                .ForMember(t => t.TopicQuestion, map => map.MapFrom(source => source.TopicsQuestions))
                .ReverseMap()
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