using Application.Aesthetic.Dtos;
using Application.Customer.Dtos;
using Application.Identity.Dtos;
using Application.PathologicalHistory.Dtos;
using Application.ProfessionalEvaluation.Dtos;
using Application.SocialHistory.Dtos;
using AutoMapper;
using Domain.Identity;

namespace Application.Helpers
{
    public class LaiseEsteticaProfile : Profile
    {
        public LaiseEsteticaProfile()
        {
            CreateMap<Domain.Customer.Entities.Customer, CustomerDto>().ReverseMap();
            CreateMap<Domain.PathologicalHistory.Entities.PathologicalHistory, PathologicalHistoryDto>().ReverseMap();
            CreateMap<Domain.AestheticHistory.Entities.AestheticHistory, AestheticHistoryDto>().ReverseMap();
            CreateMap<Domain.ProfessionalEvaluation.Entities.ProfessionalEvaluation, ProfessionalEvaluationDto>().ReverseMap();
            CreateMap<Domain.SocialHistory.Entities.SocialHistory, SocialHistoryDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
        }
    }
}
