using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class HistoryProfile : Profile
    {
        public HistoryProfile()
        {
            CreateMap<History, HistoryDTO>().ReverseMap();
        }
    }
}
