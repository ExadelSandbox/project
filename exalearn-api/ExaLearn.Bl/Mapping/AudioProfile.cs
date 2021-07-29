using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Model;

namespace ExaLearn.Bl.Mapping
{
    public class AudioProfile : Profile
    {
        public AudioProfile()
        {
            CreateMap<AudioFile, AudioFileDTO>()
                .ForMember(a => a.User, map => map.MapFrom(source => new User
                {
                    FirstName = source.User.FirstName,
                    LastName = source.User.LastName,
                    IsActive = source.User.IsActive
                }))
                .ForMember(a => a.Url, map => map.MapFrom(source => source.Url))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
