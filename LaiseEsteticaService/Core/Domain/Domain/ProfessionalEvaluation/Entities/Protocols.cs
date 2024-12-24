using System.ComponentModel.DataAnnotations;

namespace Domain.ProfessionalEvaluation.Entities;

public class Protocols
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "O campo {0} é obrigatório."),
     DataType(DataType.Date, ErrorMessage = "Formato de data inválido.")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string ProtocolCompleted { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public Guid ProfessionalEvaluationId { get; set; }
}
