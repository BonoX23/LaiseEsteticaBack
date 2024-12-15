using Microsoft.AspNetCore.Identity;

namespace Domain.Identity;

public class Role : IdentityRole<Guid>
{
    public List<UserRole> UserRoles { get; set;}
}
