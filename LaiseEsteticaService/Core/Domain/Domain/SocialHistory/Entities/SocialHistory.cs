using Domain.Enums;
using Domain.SocialHistory.Enums;
using Domain.Utils;
using System.ComponentModel.DataAnnotations;

namespace Domain.SocialHistory.Entities;

public class SocialHistory : ICustomerEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public Frequency PhysicalActivity { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public int PhysicalActivityFrequency { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public required string DaysOfTheWeek { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public Frequency HealthyEating { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public WaterIntake WaterIntake { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public Frequency AlcoholicBeverage { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public Frequency Smoker { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigtório.")]
    public Guid CustomerId { get; set; }
    public required Customer.Entities.Customer Customer { get; set; }
}
