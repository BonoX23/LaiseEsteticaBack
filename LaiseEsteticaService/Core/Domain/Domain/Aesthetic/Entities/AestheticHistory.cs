using Domain.Enums;
using Domain.Utils;

namespace Domain.AestheticHistory.Entities;

public class AestheticHistory : ICustomerEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Frequency CosmeticSurgery { get; set; }
    public string CosmeticSurgeryReason { get; set; }
    public Frequency Sunscreen { get; set; }
    public Frequency BodyCosmetics { get; set; }
    public string BodyCosmeticsReason { get; set; }
    public Guid CustomerId { get; set; }
    public Customer.Entities.Customer Customer { get; set; }
}