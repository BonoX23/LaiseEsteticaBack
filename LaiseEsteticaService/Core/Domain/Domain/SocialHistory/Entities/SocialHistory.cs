using Domain.Enums;
using Domain.SocialHistory.Enums;

namespace Domain.SocialHistory.Entities;

public class SocialHistory
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Frequency PhysicalActivity { get; set; }
    public int PhysicalActivityFrequency { get; set; }
    public string DaysOfTheWeek { get; set; }
    public Frequency HealthyEating { get; set; }
    public WaterIntake WaterIntake { get; set; }
    public Frequency AlcoholicBeverage { get; set; }
    public Frequency Smoker { get; set; }
    public Guid CustomerId { get; set; }
    public Customer.Entities.Customer Customer { get; set; }
}
