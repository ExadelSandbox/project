using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Model;

namespace ExaLearn.Bl.Mapping
{
    public class AudioProfile : Profile
    {
        public AudioProfile()
        {
            CreateMap<AudioFile, AudioFileDTO>().ReverseMap();
        }
    }
}
