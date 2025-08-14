using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Repositories;

namespace planMyMDVisit.Models.ViewModels
{
    public class AdminMainMenu
    {
        //private readonly IUserRepository userRepository;

        //public List<User> AllUsers { get; set; }
        public List<User> Users { get; set; }     
        public List<Doctor> Doctors { get; set; }
        public List<Patient> Patients { get; set; }
        //public List<Doctor> DoctorsList { get; set; }
        public IEnumerable<User> AnyUsers { get; set; }
    }
}
