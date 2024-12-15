using Microsoft.EntityFrameworkCore;

namespace Domain.ProfessionalEvaluation.Entities;

[Owned]
public class Protocols
{
    public DateTime Date { get; set; }
    public string ProtocolCompleted { get; set; }
}
