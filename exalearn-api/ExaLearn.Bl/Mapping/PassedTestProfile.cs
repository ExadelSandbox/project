using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class PassedTestProfile : Profile
    {
        public PassedTestProfile()
        {
            CreateMap<PassedTest, PassedTestDTO>()
                .ForMember(x => x.UserId, map => map.MapFrom(source => source.UserId))
                .ForMember(x => x.CheckerId, map => map.MapFrom(source => source.CheckerId))
                .ForMember(x => x.AssignTestId, map => map.MapFrom(source => source.AssignTestId))
                .ForMember(x => x.LevelType, map => map.MapFrom(source => source.LevelType))
                .ForMember(x => x.Assessment, map => map.MapFrom(source => source.Assessment))
                .ForMember(x => x.Comment, map => map.MapFrom(source => source.Comment))
                .ForMember(x => x.Status, map => map.MapFrom(source => source.Status))
                .ForMember(x => x.PassedTestDate, map => map.MapFrom(source => source.PassedTestDate))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
