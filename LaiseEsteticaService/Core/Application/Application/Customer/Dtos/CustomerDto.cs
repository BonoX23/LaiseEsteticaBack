using Application.Aesthetic.Dtos;
using Application.PathologicalHistory.Dtos;
using Application.ProfessionalEvaluation.Dtos;
using Application.SocialHistory.Dtos;
using Domain.Customer.Enums;

namespace Application.Customer.Dtos;

public class CustomerDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public MaritalStatus MaritalStatus { get; set; }
    public string Address { get; set; }
    public string Neighborhood { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Occupation { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Complaint { get; set; }
    public SocialHistoryDto SocialHistoryDto { get; set; }
    public PathologicalHistoryDto PathologicalHistoryDto { get; set; }
    public AestheticHistoryDto AestheticHistoryDto { get; set; }
    public ProfessionalEvaluationDto ProfessionalEvaluationDto { get; set; }
}
