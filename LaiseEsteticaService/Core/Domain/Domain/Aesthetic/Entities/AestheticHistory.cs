using Domain.Enums;

namespace Domain.AestheticHistory.Entities
{
    public class AestheticHistory
    {
        public Guid Id { get; set; }
        public Frequency CosmeticSurgery { get; set; }
        public string CosmeticSurgeryReason { get; set; }
        public Frequency Sunscreen { get; set; }
        public Frequency BodyCosmetics { get; set; }
        public string BodyCosmeticsReason { get; set; }
    }
}
