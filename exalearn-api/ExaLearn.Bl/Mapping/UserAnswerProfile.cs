using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class UserAnswerProfile : Profile
    {
        public UserAnswerProfile()
        {
            CreateMap<UserAnswer, UserAnswerDTO>().ReverseMap();
        }
    }
}
