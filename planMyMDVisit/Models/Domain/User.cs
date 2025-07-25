using Microsoft.AspNetCore.Identity;

namespace planMyMDVisit.Models.Domain
{
    public class User : IdentityUser<Guid>
    {
        //public Guid Id { get; set; }
        //public Guid? PatientId { get; set; }
        //public virtual Patient? Patient { get; set; }
        //public Guid? DoctorId { get; set; }
        //public virtual Doctor? Doctor { get; set; }

        //public string UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public override string Email { get; set; }
        public string? DoctorOrPatient { get; set; }

        public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
