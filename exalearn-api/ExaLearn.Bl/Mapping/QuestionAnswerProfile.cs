using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

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
