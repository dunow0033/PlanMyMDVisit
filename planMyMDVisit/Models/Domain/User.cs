using Microsoft.AspNetCore.Identity;

namespace planMyMDVisit.Models.Domain
{
    public class User : IdentityUser<Guid>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Patient? Patient { get; set; }
        //public virtual Doctor? Doctor {  get; set; }
        //public ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
