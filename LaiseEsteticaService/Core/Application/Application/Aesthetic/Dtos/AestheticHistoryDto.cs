using Application.Customer.Dtos;
using Domain.Enums;

namespace Application.Aesthetic.Dtos
{
    public class AestheticHistoryDto
    {
        public Guid Id { get; set; }
        public Frequency CosmeticSurgery { get; set; }
        public string CosmeticSurgeryReason { get; set; }
        public Frequency Sunscreen { get; set; }
        public Frequency BodyCosmetics { get; set; }
        public string BodyCosmeticsReason { get; set; }
        public Guid CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
    }
}
