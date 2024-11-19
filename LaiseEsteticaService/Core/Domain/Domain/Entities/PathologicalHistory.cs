using Domain.Enums;
using Domain.Utils;

namespace Domain.Entities
{
    public class PathologicalHistory
    {
        public Guid Id { get; set; }
        public Frequency Surgery { get; set; }
        public string SurgeryReason { get; set; }
        public Frequency MedicalTreatment { get; set; }
        public string MedicalTreatmentReason { get; set; }
        public Frequency Medication { get; set; }
        public string MedicationReason { get; set; }
        public Frequency MedicationAllergy { get; set; }
        public string MedicationAllergyReason { get; set; }
        public Frequency BowelFunction { get; set; }
        public Frequency MenstrualCycle { get; set; }
        public string MenstrualCyclePrediction { get; set; }
        public Frequency UseOfContraceptives { get; set; }
        public string WhichContraceptive { get; set; }
        public Frequency SuspectedPregnancy { get; set; }
        public BloodPressure BloodPressure { get; set; }
        public EndocrineProblems EndocrineProblems { get; set; }
        public string OtherEndocrineProblems { get; set; }
        public Frequency HeartProblems { get; set; }
        public string HeartProblemsReason { get; set; }
        public Frequency Pacemaker { get; set; }
        public OncologicalProblem? OncologicalProblemDetails { get; set; }
        //public Frequency OncologicalProblems
        //{
        //    get => _oncologicalProblems;
        //    set
        //    {
        //        _oncologicalProblems = value;
        //        OncologicalProblemDetails = value == Frequency.Yes ? new OncologicalProblem() : null;
        //    }
        //}

        public void SetSurgeryReason(string reason)
        {
            if (Surgery == Frequency.Yes)
            {
                if (string.IsNullOrEmpty(reason))
                {
                    throw new ArgumentException("The reason for surgery is mandatory.");
                }

                // Validações adicionais (tamanho mínimo, caracteres permitidos, etc.)

                SurgeryReason = reason;
            }

            else
            {
                SurgeryReason = null;
            }
        }
        public void SetMedicalTreatment(string reason)
        {
            if (MedicalTreatment == Frequency.Yes)
            {
                if (string.IsNullOrEmpty(reason))
                {
                    throw new ArgumentException("The medical treatment is mandatory.");
                }
                MedicalTreatmentReason = reason;
            }

            else
            {
                MedicalTreatmentReason = null;
            }
        }
        public void SetMedicationReason(string reason)
        {
            if (Medication == Frequency.Yes)
            {
                if (string.IsNullOrEmpty(reason))
                {
                    throw new ArgumentException("The reason for medication is mandatory.");
                }
                MedicationReason = reason;
            }

            else
            {
                MedicationReason = null;
            }
        }
        public void SetMedicationAllergyReason(string reason)
        {
            if (MedicationAllergy == Frequency.Yes)
            {
                if (string.IsNullOrEmpty(reason))
                {
                    throw new ArgumentException("The reason for medication allergy is mandatory.");
                }
                MedicationAllergyReason = reason;
            }

            else
            {
                MedicationAllergyReason = null;
            }
        }
        public void SetMenstrualCyclePrediction(string reason)
        {
            if (MenstrualCycle == Frequency.Yes)
            {
                if (string.IsNullOrEmpty(reason))
                {
                    throw new ArgumentException("The menstrual cycle prediction is mandatory.");
                }
                MenstrualCyclePrediction = reason;
            }

            else
            {
                MenstrualCyclePrediction = null;
            }
        }
        public void SetWhichContraceptive(string reason)
        {
            if (UseOfContraceptives == Frequency.Yes)
            {
                if (string.IsNullOrEmpty(reason))
                {
                    throw new ArgumentException("Use of contraceptives is mandatory.");
                }
                WhichContraceptive = reason;
            }

            else
            {
                WhichContraceptive = null;
            }
        }
        public void SetOtherEndocrineProblems(string reason)
        {
            if (EndocrineProblems == EndocrineProblems.Other)
            {
                if (string.IsNullOrEmpty(reason))
                {
                    throw new ArgumentException("Other Endocrine Problems is mandatory.");
                }
                OtherEndocrineProblems = reason;
            }

            else
            {
                OtherEndocrineProblems = null;
            }
        }
        public void SetHeartProblemsReason(string reason)
        {
            if (HeartProblems == Frequency.Yes)
            {
                if (string.IsNullOrEmpty(reason))
                {
                    throw new ArgumentException("The reason for Heart Problems is mandatory.");
                }
                HeartProblemsReason = reason;
            }

            else
            {
                HeartProblemsReason = null;
            }
        }
    }
}
