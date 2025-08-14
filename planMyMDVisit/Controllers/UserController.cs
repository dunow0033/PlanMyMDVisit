using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;
using planMyMDVisit.Repositories;

namespace planMyMDVisit.Controllers
{
    public class UserController : Controller
    {
        private readonly IDoctorRepository doctorRepository;
        private readonly IPatientRepository patientRepository;
        private readonly IHealthCareTeamRepository healthCareTeamRepository;

        public UserController(IDoctorRepository doctorRepository, IPatientRepository patientRepository, IHealthCareTeamRepository healthCareTeamRepository)
        {
            this.doctorRepository = doctorRepository;
            this.patientRepository = patientRepository;
            this.healthCareTeamRepository = healthCareTeamRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Profile(Guid patientId)
        {
            var patient = await patientRepository.GetCurrentPatient();

            if (patient == null)
            {
                return NotFound("Patient not found.");
            }

            var viewModel = new PatientEventViewModel
            {
                Patient = patient,
                //HealthCareTeams = careTeams
            };

            return View(patient);
        }
    }
}
