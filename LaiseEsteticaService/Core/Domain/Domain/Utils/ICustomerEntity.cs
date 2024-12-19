namespace Domain.Utils
{
    public interface ICustomerEntity
    {
        Guid Id { get; set; }
        Customer.Entities.Customer Customer { get; set; }
        Guid CustomerId { get; set; }
    }
}
