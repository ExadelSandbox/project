using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Mapping
{
    public class QuestionAnswerProfile : Profile
    {
        public QuestionAnswerProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
