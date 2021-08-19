using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class UserAnswerProfile : Profile
    {
        public UserAnswerProfile()
        {
            CreateMap<UserAnswer, UserAnswerDTO>()
                .ForMember(u => u.PassedTestId, map => map.MapFrom(source => source.PassedTestId))
                .ForMember(u => u.QuestionId, map => map.MapFrom(source => source.QuestionId))               
                .ForMember(u => u.ReportedMessage, map => map.MapFrom(source => source.ReportedMessage))
                .ForMember(u => u.UserAnswer, map => map.MapFrom(source => source.Answer))
                .ForMember(u => u.Assessment, map => map.MapFrom(source => source.Assessment))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<UserAnswer, UserAnswerForCheckDTO>()
                .ForMember(u => u.Id, map => map.MapFrom(source => source.Id))
                .ForMember(u => u.QuestionId, map => map.MapFrom(source => source.QuestionId))
                .ForMember(u => u.UserAnswer, map => map.MapFrom(source => source.Answer))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
