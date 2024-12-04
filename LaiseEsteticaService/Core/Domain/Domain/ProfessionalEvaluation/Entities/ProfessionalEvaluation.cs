namespace Domain.ProfessionalEvaluation.Entities;

public class ProfessionalEvaluation
{
    public Guid Id { get; set; }
    public Hypotonia? Hypotonia { get; set; }
    public IEnumerable<Feg>? Fegs { get; set; }
    public IEnumerable<Adiposity>? Adiposities { get; set; }
    public IEnumerable<StretchMarks>? StretchMarks { get; set; }
    public string? Observations { get; set; }
    public string Objectives { get; set; }
    public IEnumerable<BiometricControl>? BiometricControls { get; set; }
    public string TreatmentProgram { get; set; }
    public IEnumerable<Protocols> Protocols { get; set; }
    public Guid CustomerId { get; set; }
    public Customer.Entities.Customer Customer { get; set; }
}
