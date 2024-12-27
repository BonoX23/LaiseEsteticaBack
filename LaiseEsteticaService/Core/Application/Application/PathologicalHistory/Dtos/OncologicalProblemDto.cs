using Domain.Enums;

namespace Application.PathologicalHistory.Dtos;

public class OncologicalProblemDto
{
    public string Location { get; set; }
    public string TreatmentTime { get; set; }
    public string Treatment { get; set; }
    public Frequency OncologicalProblems { get; set; }
}
