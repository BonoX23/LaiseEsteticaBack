using Domain.PathologicalHistory.Enums;
using Microsoft.EntityFrameworkCore;

namespace Domain.PathologicalHistory.Entities;

[Owned]
public class Endocrine
{
    public EndocrineProblems EndocrineProblems { get; set; }
    public string OtherEndocrineProblems { get; set; }
}
