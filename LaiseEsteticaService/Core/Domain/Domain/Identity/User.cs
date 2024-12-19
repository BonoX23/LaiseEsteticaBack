using Domain.Customer.Enums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Identity;

public class User : IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public MaritalStatus MaritalStatus { get; set; }
    public string Address { get; set; }
    public string Neighborhood { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Occupation { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public IEnumerable<UserRole> UserRoles { get; set; }
}
