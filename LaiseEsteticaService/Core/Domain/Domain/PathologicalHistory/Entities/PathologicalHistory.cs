using Domain.Enums;
using Domain.PathologicalHistory.Enums;

namespace Domain.PathologicalHistory.Entities;

public class PathologicalHistory
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
    public Customer.Entities.Customer Customer { get; set; }

    public void SetSurgeryReason(string reason)
    {
        if (Surgery.Frequency == Frequency.Yes)
        {
            if (string.IsNullOrEmpty(reason))
            {
                throw new ArgumentException("The reason for surgery is mandatory.");
            }
            Surgery.Reason = reason;
        }

        else
        {
            Surgery.Reason = null;
        }
    }
    public void SetMedicalTreatment(string reason)
    {
        if (MedicalTreatment.Frequency == Frequency.Yes)
        {
            if (string.IsNullOrEmpty(reason))
            {
                throw new ArgumentException("The medical treatment is mandatory.");
            }
            MedicalTreatment.Reason = reason;
        }

        else
        {
            MedicalTreatment.Reason = null;
        }
    }
    public void SetMedicationReason(string reason)
    {
        if (Medication.Frequency == Frequency.Yes)
        {
            if (string.IsNullOrEmpty(reason))
            {
                throw new ArgumentException("The reason for medication is mandatory.");
            }
            Medication.Reason = reason;
        }

        else
        {
            Medication.Reason = null;
        }
    }
    public void SetMedicationAllergyReason(string reason)
    {
        if (MedicationAllergy.Frequency == Frequency.Yes)
        {
            if (string.IsNullOrEmpty(reason))
            {
                throw new ArgumentException("The reason for medication allergy is mandatory.");
            }
            MedicationAllergy.Reason = reason;
        }

        else
        {
            MedicationAllergy.Reason = null;
        }
    }
    public void SetMenstrualCyclePrediction(string reason)
    {
        if (MenstrualCycle.Frequency == Frequency.Yes)
        {
            if (string.IsNullOrEmpty(reason))
            {
                throw new ArgumentException("The menstrual cycle prediction is mandatory.");
            }
            MenstrualCycle.Reason = reason;
        }

        else
        {
            MenstrualCycle.Reason = null;
        }
    }
    public void SetWhichContraceptive(string reason)
    {
        if (Contraceptives.Frequency == Frequency.Yes)
        {
            if (string.IsNullOrEmpty(reason))
            {
                throw new ArgumentException("Use of contraceptives is mandatory.");
            }
            Contraceptives.Reason = reason;
        }

        else
        {
            Contraceptives.Reason = null;
        }
    }
    public void SetOtherEndocrineProblems(string reason)
    {
        if (EndocrineProblems.EndocrineProblems == Enums.EndocrineProblems.Other)
        {
            if (string.IsNullOrEmpty(reason))
            {
                throw new ArgumentException("Other Endocrine Problems is mandatory.");
            }
            EndocrineProblems.OtherEndocrineProblems = reason;
        }

        else
        {
            EndocrineProblems.OtherEndocrineProblems = null;
        }
    }
    public void SetHeartProblemsReason(string reason)
    {
        if (HeartProblems.Frequency == Frequency.Yes)
        {
            if (string.IsNullOrEmpty(reason))
            {
                throw new ArgumentException("The reason for Heart Problems is mandatory.");
            }
            HeartProblems.Reason = reason;
        }

        else
        {
            HeartProblems.Reason = null;
        }
    }
    public void SetOncologicalProblemsReason(string location, string treatmentTime, string treatment)
    {
        if (OncologicalProblemDetails.OncologicalProblems == Frequency.Yes)
        {
            if (string.IsNullOrEmpty(OncologicalProblemDetails.Location) ||
                string.IsNullOrEmpty(OncologicalProblemDetails.TreatmentTime) ||
                string.IsNullOrEmpty(OncologicalProblemDetails.Treatment))
            {
                throw new ArgumentException("The reason for oncological problems is mandatory.");
            }

            OncologicalProblemDetails = new OncologicalProblem(location, treatmentTime, treatment);
        }

        else
        {
            OncologicalProblemDetails = null;
        }
    }
}
