using Domain.PathologicalHistory.Enums;

namespace Domain.PathologicalHistory.Entities;

public class Endocrine
{
    public EndocrineProblems EndocrineProblems { get; set; }
    public string OtherEndocrineProblems { get; set; }
}
