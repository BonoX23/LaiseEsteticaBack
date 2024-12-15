using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;
using Microsoft.EntityFrameworkCore;

namespace Domain.ProfessionalEvaluation.Entities;

[Owned]
public class Feg : BodyRegion
{
    public Features FegFeatures { get; set; }
    public FegIntensity FegIntensity { get; set; }
}
