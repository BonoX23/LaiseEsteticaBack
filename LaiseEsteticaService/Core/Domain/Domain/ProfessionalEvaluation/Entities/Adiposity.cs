using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;
using System.ComponentModel.DataAnnotations;

namespace Domain.ProfessionalEvaluation.Entities;

public class Adiposity : BodyRegion
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public Features AdiposityFeature { get; set; }
    public Guid ProfessionalEvaluationId { get; set; }
}
