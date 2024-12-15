using Domain.Identity;

namespace Domain.Customer.Entities;

public class Customer
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public User User { get; set; }
    public string Complaint { get; set; }
    public SocialHistory.Entities.SocialHistory SocialHistory { get; set; }
    public PathologicalHistory.Entities.PathologicalHistory PathologicalHistory { get; set; }
    public AestheticHistory.Entities.AestheticHistory AestheticHistory { get; set; }
    public ProfessionalEvaluation.Entities.ProfessionalEvaluation ProfessionalEvaluation { get; set; }
}
