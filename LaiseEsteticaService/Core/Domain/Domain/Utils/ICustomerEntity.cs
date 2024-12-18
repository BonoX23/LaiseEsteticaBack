namespace Domain.Utils
{
    public interface ICustomerEntity
    {
        Guid Id { get; set; }
        Guid CustomerId { get; set; }
    }
}
