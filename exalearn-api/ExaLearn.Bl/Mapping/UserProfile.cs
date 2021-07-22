using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();

            CreateMap<History, UserHistoryDTO>()
               .ForMember(x => x.Level, map => map.MapFrom(source => source.User.LevelType))
               .ForMember(x => x.Date, map => map.MapFrom(source => source.PassedTest.PassedTestDate))
               .ForMember(x => x.Mark, map => map.MapFrom(source => source.PassedTest.Assessment))
               .ReverseMap();

            CreateMap<History, HRHistoryDTO>()
              .ForMember(x => x.FullName, map => map.MapFrom(source => source.User.FirstName + source.User.LastName))
              .ReverseMap();
        }
    }
}
