using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class PassedTestProfile : Profile
    {
        public PassedTestProfile()
        {
            CreateMap<PassedTest, GenerateTestDTO>()
                .ForMember(x => x.UserId, map => map.MapFrom(source => source.UserId))
                .ForMember(x => x.CheckerId, map => map.MapFrom(source => source.CheckerId))
                .ForMember(x => x.AssignTestId, map => map.MapFrom(source => source.AssignTestId))
                .ForMember(x => x.LevelType, map => map.MapFrom(source => source.LevelType))
                .ForMember(x => x.Status, map => map.MapFrom(source => source.Status))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<PassedTest, PassedTestForCheckDTO>()           
                .ForMember(x => x.UserAnswers, map => map.MapFrom(source => source.UserAnswers))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<PassedTest, PassedTestDTO>()
                .ForMember(x => x.FullName, map => map.MapFrom(source => $"{source.User.FirstName} {source.User.LastName}"))
                .ForMember(x => x.LevelType, map => map.MapFrom(source => source.LevelType))
                .ForMember(x => x.PassedTestDate, map => map.MapFrom(source => source.PassedTestDate))
                .ForMember(x => x.Assessment, map => map.MapFrom(source => source.Assessment.General))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
