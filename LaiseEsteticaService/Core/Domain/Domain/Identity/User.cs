using Domain.Customer.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Domain.Identity;

public class User : IdentityUser<Guid>
{
    [Required(ErrorMessage = "O campo {0} é obrigatório."),
     StringLength(30, MinimumLength = 3,
     ErrorMessage = "O campo {0} deve ter entre 3 e 30 caracteres.")]
    public required string FirstName { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório."),
     StringLength(30, MinimumLength = 3,
     ErrorMessage = "O campo {0} deve ter entre 3 e 30 caracteres.")]
    public required string LastName { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório."),
     DataType(DataType.Date, ErrorMessage = "Formato de data inválido.")]
    public DateTime DateOfBirth { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public MaritalStatus MaritalStatus { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório."),
     StringLength(50, MinimumLength = 5,
     ErrorMessage = "O campo {0} deve ter entre 5 e 50 caracteres.")]
    public required string Address { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório."),
     StringLength(30, MinimumLength = 3,
     ErrorMessage = "O campo {0} deve ter entre 3 e 30 caracteres.")]
    public required string Neighborhood { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório."),
     StringLength(50, MinimumLength = 3,
     ErrorMessage = "O campo {0} deve ter entre 3 e 50 caracteres.")]
    public required string City { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório."),
     StringLength(2, MinimumLength = 2,
     ErrorMessage = "O campo {0} deve ter 2 caracteres.")]
    public required string State { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório."),
     StringLength(8, MinimumLength = 8,
     ErrorMessage = "O campo {0} deve ter 8 caracteres.")]
    public required string ZipCode { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório."),
     StringLength(50, MinimumLength = 3,
     ErrorMessage = "O campo {0} deve ter entre 3 e 50 caracteres.")]
    public required string Occupation { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public IEnumerable<UserRole> UserRoles { get; set; }
}
