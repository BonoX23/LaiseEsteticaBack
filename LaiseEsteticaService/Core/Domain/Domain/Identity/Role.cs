using Microsoft.AspNetCore.Identity;

namespace Domain.Identity;

public class Role : IdentityRole<Guid>
{
    public required List<UserRole> UserRoles { get; set;}
}
