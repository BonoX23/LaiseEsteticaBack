using Domain.Enums;

namespace Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string Address { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Occupation { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Complaint { get; set; }
        public SocialHistory SocialHistory { get; set; }
        public PathologicalHistory PathologicalHistory { get; set; }
        //public AestheticHistory AestheticHistory { get; set; }


    }
}
