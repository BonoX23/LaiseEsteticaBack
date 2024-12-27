using Domain.Enums;
using Domain.PathologicalHistory.Enums;
using Domain.Utils;
using System.ComponentModel.DataAnnotations;

namespace Domain.PathologicalHistory.Entities;

public class PathologicalHistory : ICustomerEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public required Surgery Surgery { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public required MedicalTreatment MedicalTreatment { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public required Medication Medication { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public required MedicationAllergy MedicationAllergy { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public Frequency BowelFunction { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public required MenstrualCycle MenstrualCycle { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public required Contraceptives Contraceptives { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public Frequency SuspectedPregnancy { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public BloodPressure BloodPressure { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public required Endocrine EndocrineProblems { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public required HeartProblems HeartProblems { get; set; }

    public OncologicalProblem? OncologicalProblemDetails { get; set; }
    public Guid CustomerId { get; set; }
    public required Customer.Entities.Customer Customer { get; set; }

    public void SetReason(Frequency frequency, string reason, ref string? targetProperty, string errorMessage)
    {
        if (frequency == Frequency.Yes)
        {
            if (string.IsNullOrEmpty(reason))
            {
                throw new ArgumentException(errorMessage);
            }
            targetProperty = reason;
        }
        else
        {
            targetProperty = null;
        }
    }

    public void SetOtherEndocrineProblems(string reason)
    {
        if (EndocrineProblems.EndocrineProblems == Enums.EndocrineProblems.Other)
        {
            if (string.IsNullOrEmpty(reason))
            {
                throw new ArgumentException("Outros problemas endócrinos são obrigatório.");
            }
            EndocrineProblems.OtherEndocrineProblems = reason;
        }
        else
        {
            EndocrineProblems.OtherEndocrineProblems = null;
        }
    }

    public void SetOncologicalProblemsReason(string location, string treatmentTime, string treatment)
    {
        if (OncologicalProblemDetails != null && OncologicalProblemDetails.OncologicalProblems == Frequency.Yes)
        {
            if (string.IsNullOrEmpty(OncologicalProblemDetails.Location) ||
                string.IsNullOrEmpty(OncologicalProblemDetails.TreatmentTime) ||
                string.IsNullOrEmpty(OncologicalProblemDetails.Treatment))
            {
                throw new ArgumentException("A causa dos problemas oncológicos é obrigatória.");
            }

            OncologicalProblemDetails = new OncologicalProblem(location, treatmentTime, treatment);
        }
        else
        {
            OncologicalProblemDetails = null;
        }
    }
}
