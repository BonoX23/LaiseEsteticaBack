using Domain.Utils;
using System.ComponentModel.DataAnnotations;

namespace Domain.ProfessionalEvaluation.Entities;

public class ProfessionalEvaluation : ICustomerEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public Hypotonia? Hypotonia { get; set; }

    public IEnumerable<Feg>? Fegs { get; set; }

    public IEnumerable<Adiposity>? Adiposities { get; set; }

    public IEnumerable<StretchMarks>? StretchMarks { get; set; }

    public string? Observations { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public string Objectives { get; set; }

    public IEnumerable<BiometricControl>? BiometricControls { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public string TreatmentProgram { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public IEnumerable<Protocols> Protocols { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public Guid CustomerId { get; set; }
    public Customer.Entities.Customer Customer { get; set; }
}
