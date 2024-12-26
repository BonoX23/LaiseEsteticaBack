using Domain.PathologicalHistory.Enums;

namespace Application.PathologicalHistory.Dtos;

public class EndocrineDto
{
    public EndocrineProblems EndocrineProblems { get; set; }
    public string? OtherEndocrineProblems { get; set; }
}
