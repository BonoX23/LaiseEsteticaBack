using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Domain.PathologicalHistory.Entities;

[Owned]
public class OncologicalProblem
{
    public string Location { get; set; }
    public string TreatmentTime { get; set; }
    public string Treatment { get; set; }
    public Frequency OncologicalProblems { get; set; }

    public OncologicalProblem(string location, string treatmentTime, string treatment)
    {
        Location = location;
        TreatmentTime = treatmentTime;
        Treatment = treatment;
    }
}
