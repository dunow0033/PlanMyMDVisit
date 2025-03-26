using Microsoft.AspNetCore.Identity;

namespace planMyMDVisit.Models.Domain
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Patient Patient { get; set; }

        public Doctor Doctor {  get; set; }
        //public ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
