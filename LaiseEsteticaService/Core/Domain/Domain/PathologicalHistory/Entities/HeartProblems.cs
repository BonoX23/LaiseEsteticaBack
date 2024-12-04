using Domain.Enums;
using Domain.PathologicalHistory.Shared;

namespace Domain.PathologicalHistory.Entities;

public class HeartProblems : History
{
    public Frequency Pacemaker { get; set; }
}
