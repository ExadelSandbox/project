using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
                .ForMember(x => x.RoleName, map => map.Ignore())
                .ReverseMap();

            CreateMap<string, UserDTO>()
                .ForMember(u => u.RoleName, map => map.MapFrom(source => source))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<PassedTest, HrHistoryDTO>()
                .ForMember(x => x.FullName, map => map.MapFrom(source => $"{source.User.FirstName} {source.User.LastName}"))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<AssignTest, UserAssignedTestDTO>()
                .ForMember(x => x.Level, map => map.MapFrom(source => source.LevelType))
                .ForMember(x => x.ExpireDate, map => map.MapFrom(source => source.ExpirationDate))
                .ForMember(x => x.AssignedBy, map => map.MapFrom(source => $"{source.Assigner.FirstName} {source.Assigner.LastName}"))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<AssignTest, HrAssignedTestDTO>()
                .ForMember(x => x.Level, map => map.MapFrom(source => source.LevelType))
                .ForMember(x => x.ExpireDate, map => map.MapFrom(source => source.ExpirationDate))
                .ForMember(x => x.Username, map => map.MapFrom(source => $"{source.User.FirstName} {source.User.LastName}"))
                .ForMember(x => x.Passed, map => map.Ignore())
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<AssignTest, AssignedTestDTO>()
                .ForMember(x => x.Level, map => map.MapFrom(source => source.LevelType))
                .ForMember(x => x.ExpireDate, map => map.MapFrom(source => source.ExpirationDate))
                .ForMember(x => x.HrId, map => map.MapFrom(source => source.AssignerId))
                .ForMember(x => x.UserId, map => map.MapFrom(source => source.UserId))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
