using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;

namespace Domain.ProfessionalEvaluation.Entities;

public class Adiposity : BodyRegion
{
    public Features AdiposityFeature { get; set; }
}
