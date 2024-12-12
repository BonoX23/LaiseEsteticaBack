namespace Application.Identity.Dtos;

public class UserUpdateDto : UserDto
{
    public Guid Id { get; set; }
    public string Token { get; set; }
}
