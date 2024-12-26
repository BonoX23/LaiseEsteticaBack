using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;

namespace Application.ProfessionalEvaluation.Dtos;

public class StretchMarksDto : BodyRegion
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Features StretchMarksFeature { get; set; }
    public Guid ProfessionalEvaluationId { get; set; }
}
