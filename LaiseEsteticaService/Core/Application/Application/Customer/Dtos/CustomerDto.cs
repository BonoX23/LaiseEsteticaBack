using Application.Aesthetic.Dtos;
using Application.Identity.Dtos;
using Application.PathologicalHistory.Dtos;
using Application.ProfessionalEvaluation.Dtos;
using Application.SocialHistory.Dtos;

namespace Application.Customer.Dtos;

public class CustomerDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public UserDto User { get; set; }
    public string Complaint { get; set; }
    public SocialHistoryDto SocialHistory { get; set; }
    public PathologicalHistoryDto PathologicalHistory { get; set; }
    public AestheticHistoryDto AestheticHistory { get; set; }
    public ProfessionalEvaluationDto ProfessionalEvaluation { get; set; }
}
