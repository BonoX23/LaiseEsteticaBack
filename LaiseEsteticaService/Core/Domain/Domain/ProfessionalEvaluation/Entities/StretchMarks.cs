using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;
using Microsoft.EntityFrameworkCore;

namespace Domain.ProfessionalEvaluation.Entities;

[Owned]
public class StretchMarks : BodyRegion
{
    public Features StretchMarksFeature { get; set; }
}
