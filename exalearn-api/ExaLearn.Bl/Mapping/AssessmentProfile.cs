using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class AssessmentProfile : Profile
    {
        public AssessmentProfile()
        {
            CreateMap<Assessment, AssessmentDTO>()
                .ForMember(a => a.Essay, map => map.MapFrom(source => source.Essay))
                .ForMember(a => a.Speaking, map => map.MapFrom(source => source.Speaking))
                .ForMember(a => a.passedTestId, map => map.Ignore())
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
