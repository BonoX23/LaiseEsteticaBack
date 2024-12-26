using Domain.ProfessionalEvaluation.Enums;

namespace Application.ProfessionalEvaluation.Dtos;

public class FegDto
{
    public Guid Id { get; set; }
    public Features FegFeatures { get; set; }
    public FegIntensity FegIntensity { get; set; }
    public Guid ProfessionalEvaluationId { get; set; }
}
