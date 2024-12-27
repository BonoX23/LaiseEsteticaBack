using Domain.Identity;
using System.ComponentModel.DataAnnotations;

namespace Domain.Customer.Entities;

public class Customer
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public required User User { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório."), 
        StringLength(50, MinimumLength = 3,
        ErrorMessage = "Intervalo permitido de 3 a 50 caracteres.")]
    public required string Complaint { get; set; }

    public required SocialHistory.Entities.SocialHistory SocialHistory { get; set; }

    public required PathologicalHistory.Entities.PathologicalHistory PathologicalHistory { get; set; }

    public required AestheticHistory.Entities.AestheticHistory AestheticHistory { get; set; }

    public required ProfessionalEvaluation.Entities.ProfessionalEvaluation ProfessionalEvaluation { get; set; }
}