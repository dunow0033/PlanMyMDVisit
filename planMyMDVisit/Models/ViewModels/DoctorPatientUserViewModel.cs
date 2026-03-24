using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Models.ViewModels
{
    public class DoctorPatientUserViewModel
    {
        public User User { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
