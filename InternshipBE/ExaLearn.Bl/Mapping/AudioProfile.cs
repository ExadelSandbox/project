using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Mapping
{
    public class AudioProfile : Profile
    {
        public AudioProfile()
        {
            CreateMap<AudioFile, AudioFileDTO>();
        }
    }
}
