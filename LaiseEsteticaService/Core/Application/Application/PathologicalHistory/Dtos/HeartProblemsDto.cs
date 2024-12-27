using Domain.Enums;
using Domain.PathologicalHistory.Shared;

namespace Application.PathologicalHistory.Dtos;

public class HeartProblemsDto : History
{
    public Frequency Pacemaker { get; set; }
}
