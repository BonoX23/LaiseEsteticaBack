namespace Domain.ProfessionalEvaluation.Entities;

public class BiometricControl
{
    public DateTime Date { get; set; }
    public decimal UpperAbdomen { get; set; }
    public decimal DownperAbdomen { get; set; }
    public decimal Waist { get; set; }
    public decimal Hip { get; set; }
    public decimal Breeches { get; set; }
    public decimal RightThigh { get; set; }
    public decimal LeftThigh { get; set;}
    public decimal RightArm { get; set; }
    public decimal LeftArm { get; set; }
}
