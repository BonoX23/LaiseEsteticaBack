using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;

namespace Domain.ProfessionalEvaluation.Entities;

public class Adiposity : BodyRegion
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Features AdiposityFeature { get; set; }
    public Guid ProfessionalEvaluationId { get; set; }
}
