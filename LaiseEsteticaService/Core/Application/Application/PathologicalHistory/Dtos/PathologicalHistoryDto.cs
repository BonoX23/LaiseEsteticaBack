using Application.Customer.Dtos;
using Domain.Enums;
using Domain.PathologicalHistory.Entities;
using Domain.PathologicalHistory.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PathologicalHistory.Dtos;

public class PathologicalHistoryDto
{
    public Guid Id { get; set; }
    public Surgery Surgery { get; set; }
    public MedicalTreatment MedicalTreatment { get; set; }
    public Medication Medication { get; set; }
    public MedicationAllergy MedicationAllergy { get; set; }
    public Frequency BowelFunction { get; set; }
    public MenstrualCycle MenstrualCycle { get; set; }
    public Contraceptives Contraceptives { get; set; }
    public Frequency SuspectedPregnancy { get; set; }
    public BloodPressure BloodPressure { get; set; }
    public Endocrine EndocrineProblems { get; set; }
    public HeartProblems HeartProblems { get; set; }
    public OncologicalProblem? OncologicalProblemDetails { get; set; }
    public Guid CustomerId { get; set; }
    public CustomerDto CustomerDto { get; set; }
}
