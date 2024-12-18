namespace Domain.ProfessionalEvaluation.Entities;

public class Protocols
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Date { get; set; }
    public string ProtocolCompleted { get; set; }
    public Guid ProfessionalEvaluationId { get; set; }
}
