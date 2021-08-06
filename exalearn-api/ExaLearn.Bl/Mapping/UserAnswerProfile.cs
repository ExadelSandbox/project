﻿using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;

namespace ExaLearn.Bl.Mapping
{
    public class UserAnswerProfile : Profile
    {
        public UserAnswerProfile()
        {
            CreateMap<UserAnswer, UserAnswerDTO>()
                .ForMember(u => u.PassedTestId, map => map.MapFrom(source => source.PassedTestId))
                .ForMember(u => u.QuestionId, map => map.MapFrom(source => source.QuestionId))
                .ForMember(u => u.ReportId, map => map.MapFrom(source => source.ReportId))
                .ForMember(u => u.Answer, map => map.MapFrom(source => source.Answer))
                .ReverseMap()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
