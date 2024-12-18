using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;

namespace Domain.ProfessionalEvaluation.Entities;

public class StretchMarks : BodyRegion
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Features StretchMarksFeature { get; set; }
    public Guid ProfessionalEvaluationId { get; set; }
}
