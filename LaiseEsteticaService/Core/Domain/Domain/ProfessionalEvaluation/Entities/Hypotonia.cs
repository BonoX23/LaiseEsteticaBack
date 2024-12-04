using Domain.ProfessionalEvaluation.Enums;
using Domain.ProfessionalEvaluation.Shared;

namespace Domain.ProfessionalEvaluation.Entities;

public class Hypotonia : BodyRegion
{
    public HypotoniaType Type { get; set; }
}
