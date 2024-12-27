using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;

namespace Application.ProfessionalEvaluation.Dtos;

public class HypotoniaDto : BodyRegion
{
    public Guid Id { get; set; }
    public HypotoniaType Type { get; set; }
}
