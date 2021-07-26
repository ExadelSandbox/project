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
            CreateMap<List<GrammarQuestionDTO>, TestDTO>()
                .ForMember(t => t.GrammarQuestion, map => map.MapFrom(source => source))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<List<AuditionQuestionDTO>, TestDTO>()
                .ForMember(t => t.AuditionQuestion, map => map.MapFrom(source => source))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<TopicQuestionDTO, TestDTO>()
                .ForMember(t => t.EssayTopic, map => map.MapFrom(source => source.Topic))
                .ForMember(t => t.SpeakingTopic, map => map.MapFrom(source => source.Topic))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<Question, GrammarQuestionDTO>()
                .ForMember(x => x.Level, map => map.MapFrom(source => source.Type))
                .ForMember(x => x.Question, map => map.MapFrom(source => source.Text))
                .ForMember(x => x.Answers, map => map.MapFrom(source => source.Answers))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<Question, AuditionQuestionDTO>()
                .ForMember(x => x.Level, map => map.MapFrom(source => source.LevelType))
                .ForMember(x => x.Url, map => map.MapFrom(source => source.AudioFile.Url))
                .ForMember(x => x.Question, map => map.MapFrom(source => source.Text))
                .ForMember(x => x.Answers, map => map.MapFrom(source => source.Answers))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<Question, TopicQuestionDTO>()
                .ForMember(x => x.Level, map => map.MapFrom(source => source.Type))
                .ForMember(x => x.Topic, map => map.MapFrom(source => source.Text))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}