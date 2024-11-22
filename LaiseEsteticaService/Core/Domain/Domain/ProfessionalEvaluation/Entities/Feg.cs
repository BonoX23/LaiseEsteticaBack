using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;

namespace Domain.ProfessionalEvaluation.Entities;

public class Feg : BodyRegion
{
    public Features FegFeatures { get; set; }
    public FegIntensity FegIntensity { get; set; }
}
