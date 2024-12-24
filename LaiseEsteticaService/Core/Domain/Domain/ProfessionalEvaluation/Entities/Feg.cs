using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;
using System.ComponentModel.DataAnnotations;

namespace Domain.ProfessionalEvaluation.Entities;

public class Feg : BodyRegion
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public Features FegFeatures { get; set; }
    public FegIntensity FegIntensity { get; set; }
    public Guid ProfessionalEvaluationId { get; set; }
}