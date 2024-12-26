using Application.Customer.Dtos;
using Domain.Enums;
using Domain.PathologicalHistory.Enums;

namespace Application.PathologicalHistory.Dtos;

public class PathologicalHistoryDto
{
    public Guid Id { get; set; }
    public SurgeryDto Surgery { get; set; }
    public MedicalTreatmentDto MedicalTreatment { get; set; }
    public MedicationDto Medication { get; set; }
    public MedicationAllergyDto MedicationAllergy { get; set; }
    public Frequency BowelFunction { get; set; }
    public MenstrualCycleDto MenstrualCycle { get; set; }
    public ContraceptivesDto ContraceptivesDto { get; set; }
    public Frequency SuspectedPregnancy { get; set; }
    public BloodPressure BloodPressure { get; set; }
    public EndocrineDto EndocrineProblems { get; set; }
    public HeartProblemsDto HeartProblems { get; set; }
    public OncologicalProblemDto? OncologicalProblemDetails { get; set; }
    public Guid CustomerId { get; set; }
    public CustomerDto Customer { get; set; }
}
