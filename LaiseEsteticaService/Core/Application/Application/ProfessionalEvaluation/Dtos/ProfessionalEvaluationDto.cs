using Application.Customer.Dtos;
using Domain.ProfessionalEvaluation.Entities;

namespace Application.ProfessionalEvaluation.Dtos;

public class ProfessionalEvaluationDto
{
    public Guid Id { get; set; }
    public HypotoniaDto? Hypotonia{ get; set; }
    public IEnumerable<FegDto>? Feg { get; set; }
    public IEnumerable<AdiposityDto>? Adiposity{ get; set; }
    public IEnumerable<StretchMarksDto>? StretchMarks { get; set; }
    public string? Observations { get; set; }
    public string Objectives { get; set; }
    public IEnumerable<BiometricControlDto>? BiometricControl { get; set; }
    public string TreatmentProgram { get; set; }
    public IEnumerable<ProtocolsDto> Protocols { get; set; }
    public Guid CustomerId { get; set; }
    public CustomerDto Customer { get; set; }
}
