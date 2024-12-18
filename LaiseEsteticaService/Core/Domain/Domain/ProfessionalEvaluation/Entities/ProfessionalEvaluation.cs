namespace Domain.ProfessionalEvaluation.Entities;

public class ProfessionalEvaluation
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Hypotonia? Hypotonia { get; set; }
    public List<Feg>? Fegs { get; set; }
    public List<Adiposity>? Adiposities { get; set; }
    public List<StretchMarks>? StretchMarks { get; set; }
    public string? Observations { get; set; }
    public string Objectives { get; set; }
    public List<BiometricControl>? BiometricControls { get; set; }
    public string TreatmentProgram { get; set; }
    public List<Protocols> Protocols { get; set; }
    public Guid CustomerId { get; set; }
    public Customer.Entities.Customer Customer { get; set; }
}
