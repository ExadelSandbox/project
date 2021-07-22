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
                .ForMember(x => x.AnswersId, map => map.MapFrom(source => source.Answers))
                .ReverseMap();

            CreateMap<Question, AudioQuestionDTO>()
                .ForMember(x => x.Level, map => map.MapFrom(source => source.LevelType))
                .ForMember(x => x.FileId, map => map.MapFrom(source => source.AudioId))
                .ForMember(x => x.Question, map => map.MapFrom(source => source.Text))
                .ForMember(x => x.AnswersId, map => map.MapFrom(source => source.Answers))
                .ReverseMap();
        }
    }
}
