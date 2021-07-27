using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class AssignedTestProfile : Profile
    {
        public AssignedTestProfile()
        {
            CreateMap<AssignTest, AssignedTestDTO>()
                .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.LevelType))
                .ForMember(dest => dest.ExpireDate, opt => opt.MapFrom(src => src.ExpirationDate))
                .ForMember(dest => dest.HrId, opt => opt.MapFrom(src => src.AssignerId));
        }
    }
}
