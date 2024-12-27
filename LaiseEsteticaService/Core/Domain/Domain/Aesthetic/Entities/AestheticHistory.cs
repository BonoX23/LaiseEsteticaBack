using Domain.Enums;
using Domain.Utils;
using System.ComponentModel.DataAnnotations;

namespace Domain.AestheticHistory.Entities;

public class AestheticHistory : ICustomerEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public Frequency CosmeticSurgery { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public required string CosmeticSurgeryReason { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public Frequency Sunscreen { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public Frequency BodyCosmetics { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public required string BodyCosmeticsReason { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public Guid CustomerId { get; set; }
    public required Customer.Entities.Customer Customer { get; set; }
}