namespace Domain.Utils
{
    public class OncologicalProblem
    {
        public string Location { get; set; }
        public string TreatmentTime { get; set; }
        public string Treatment { get; set; }

        public OncologicalProblem(string location, string treatmentTime, string treatment)
        {
            Location = location;
            TreatmentTime = treatmentTime;
            Treatment = treatment;
        }
    }
}
