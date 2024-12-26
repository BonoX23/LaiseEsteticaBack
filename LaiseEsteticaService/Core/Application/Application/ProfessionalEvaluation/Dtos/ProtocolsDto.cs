namespace Application.ProfessionalEvaluation.Dtos;

public class ProtocolsDto
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string ProtocolCompleted { get; set; }
    public Guid ProfessionalEvaluationId { get; set; }
}
