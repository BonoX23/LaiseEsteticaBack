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
    public UserDto UserDto { get; set; }
    public string Complaint { get; set; }
    public SocialHistoryDto SocialHistoryDto { get; set; }
    public PathologicalHistoryDto PathologicalHistoryDto { get; set; }
    public AestheticHistoryDto AestheticHistoryDto { get; set; }
    public ProfessionalEvaluationDto ProfessionalEvaluationDto { get; set; }
}
