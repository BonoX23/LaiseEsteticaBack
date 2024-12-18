using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;
using Microsoft.EntityFrameworkCore;

namespace Domain.ProfessionalEvaluation.Entities;

[Owned]
public class Hypotonia : BodyRegion
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public HypotoniaType Type { get; set; }
}
