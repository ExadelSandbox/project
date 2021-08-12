using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class UserTestProfile : Profile
    {
        public UserTestProfile()
        {
            CreateMap<UserTest, UserTestDTO>()
                .ForMember(x => x.Id, map => map.MapFrom(source => source.Id))
                .ForMember(x => x.Questions, map => map.MapFrom(source => source.Questions))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());

        }
    }
}
