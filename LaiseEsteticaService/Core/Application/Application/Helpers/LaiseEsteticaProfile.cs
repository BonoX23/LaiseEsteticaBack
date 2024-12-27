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

            CreateMap<Domain.AestheticHistory.Entities.AestheticHistory, AestheticHistoryDto>().ReverseMap();
            CreateMap<Domain.Customer.Entities.Customer, CustomerDto>().ReverseMap();
            CreateMap<Domain.PathologicalHistory.Entities.PathologicalHistory, PathologicalHistoryDto>().ReverseMap();
            CreateMap<Domain.ProfessionalEvaluation.Entities.ProfessionalEvaluation, ProfessionalEvaluationDto>().ReverseMap();
            CreateMap<Domain.SocialHistory.Entities.SocialHistory, SocialHistoryDto>().ReverseMap();

            //PathologicalHistory
            CreateMap<Domain.PathologicalHistory.Entities.Contraceptives, ContraceptivesDto>().ReverseMap();
            CreateMap<Domain.PathologicalHistory.Entities.Endocrine, EndocrineDto>().ReverseMap();
            CreateMap<Domain.PathologicalHistory.Entities.HeartProblems, HeartProblemsDto>().ReverseMap();
            CreateMap<Domain.PathologicalHistory.Entities.MedicalTreatment, MedicalTreatmentDto>().ReverseMap();
            CreateMap<Domain.PathologicalHistory.Entities.MedicationAllergy, MedicationAllergyDto>().ReverseMap();
            CreateMap<Domain.PathologicalHistory.Entities.Medication, MedicationDto>().ReverseMap();
            CreateMap<Domain.PathologicalHistory.Entities.MenstrualCycle, MenstrualCycleDto>().ReverseMap();
            CreateMap<Domain.PathologicalHistory.Entities.OncologicalProblem, OncologicalProblemDto>().ReverseMap();
            CreateMap<Domain.PathologicalHistory.Entities.Surgery, SurgeryDto>().ReverseMap();

            //ProfessionalEvaluation
            CreateMap<Domain.ProfessionalEvaluation.Entities.Adiposity, AdiposityDto>().ReverseMap();
            CreateMap<Domain.ProfessionalEvaluation.Entities.BiometricControl, BiometricControlDto>().ReverseMap();
            CreateMap<Domain.ProfessionalEvaluation.Entities.Feg, FegDto>().ReverseMap();
            CreateMap<Domain.ProfessionalEvaluation.Entities.Hypotonia, HypotoniaDto>().ReverseMap();
            CreateMap<Domain.ProfessionalEvaluation.Entities.Protocols, ProtocolsDto>().ReverseMap();
            CreateMap<Domain.ProfessionalEvaluation.Entities.StretchMarks, StretchMarksDto>().ReverseMap();

            //Identity
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
        }
    }
}
