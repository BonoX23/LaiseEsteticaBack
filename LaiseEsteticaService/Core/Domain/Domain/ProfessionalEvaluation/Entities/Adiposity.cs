using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;
using Microsoft.EntityFrameworkCore;

namespace Domain.ProfessionalEvaluation.Entities;

[Owned]
public class Adiposity : BodyRegion
{
    public Features AdiposityFeature { get; set; }
}
