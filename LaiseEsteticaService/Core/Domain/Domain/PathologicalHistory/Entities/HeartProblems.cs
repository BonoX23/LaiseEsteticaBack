using Domain.Enums;
using Domain.PathologicalHistory.Shared;
using Microsoft.EntityFrameworkCore;

namespace Domain.PathologicalHistory.Entities;

[Owned]
public class HeartProblems : History
{
    public Frequency Pacemaker { get; set; }
}
