using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<Question, QuestionDTO>().ReverseMap();

            CreateMap<Question, GrammarQuestionDTO>()
                .ForMember(x => x.Level, map => map.MapFrom(source => source.Type))
                .ForMember(x => x.Question, map => map.MapFrom(source => source.Text))
                .ForMember(x => x.Answers, map => map.MapFrom(source => source.Answers))
                .ReverseMap();

            CreateMap<Question, AudioQuestionDTO>()
                .ForMember(x => x.Level, map => map.MapFrom(source => source.LevelType))
                .ForMember(x => x.FileUrl, map => map.MapFrom(source => source.AudioFile.Url))
                .ForMember(x => x.Question, map => map.MapFrom(source => source.Text))
                .ForMember(x => x.Answers, map => map.MapFrom(source => source.Answers))
                .ReverseMap();

            CreateMap<Question, TopicQuestionDTO>()
                .ForMember(x => x.Level, map => map.MapFrom(source => source.Type))
                .ForMember(x => x.Topic, map => map.MapFrom(source => source.Text))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());               
        }
    }
}
