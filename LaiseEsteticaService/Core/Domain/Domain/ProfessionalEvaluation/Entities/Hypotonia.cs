using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;
using Microsoft.EntityFrameworkCore;

namespace Domain.ProfessionalEvaluation.Entities;

[Owned]
public class Hypotonia : BodyRegion
{
    public HypotoniaType Type { get; set; }
}
