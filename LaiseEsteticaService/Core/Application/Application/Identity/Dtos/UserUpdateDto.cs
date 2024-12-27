using System.ComponentModel.DataAnnotations;

namespace Application.Identity.Dtos;

public class UserUpdateDto : UserDto
{
    [Key]
    public Guid Id { get; set; }
    public string Token { get; set; }
}
