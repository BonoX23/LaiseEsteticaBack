using Domain.Enums;

namespace Domain.Entities
{
    public class SocialHistory
    {
        public Frequency PhysicalActivity { get; set; }
        public int PhysicalActivityFrequency { get; set; }
        public string DaysOfTheWeek { get; set; }
        public Frequency HealthyEating { get; set; }
        public WaterIntake WaterIntake { get; set; }
        public Frequency AlcoholicBeverage { get; set; }
        public Frequency Smoker { get; set; }
    }
}
