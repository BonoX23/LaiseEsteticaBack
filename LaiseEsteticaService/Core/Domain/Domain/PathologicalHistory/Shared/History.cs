using Domain.Enums;

namespace Domain.PathologicalHistory.Shared;

public abstract class History
{
    public Frequency Frequency { get; set; }
    public required string Reason { get; set; }
}
