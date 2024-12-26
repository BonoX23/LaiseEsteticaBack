using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;

namespace Application.ProfessionalEvaluation.Dtos;

public class AdiposityDto : BodyRegion
{
    public Guid Id { get; set; }
    public Features AdiposityFeature { get; set; }
    public Guid ProfessionalEvaluationId { get; set; }
}
