using Microsoft.AspNetCore.Mvc;
using planMyMDVisit.Repositories;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;

namespace planMyMDVisit.Controllers
{
    public class PatientsController : Controller
    {
        private readonly IPatientRepository patientRepository;
        private readonly IHealthCareTeamRepository healthCareTeamRepository;

        public PatientsController(IPatientRepository patientRepository, IHealthCareTeamRepository healthCareTeamRepository)
        {
            this.patientRepository = patientRepository;
            this.healthCareTeamRepository = healthCareTeamRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Show()
        {
            ViewData["events"] = new[]
            {
                new Event{ Id = 1, Title = "Video for Marisa", StartDate = "19-06-2025" },
                new Event{ Id = 2, Title = "Preparation", StartDate = "12-06-2025" },
            };

            //get patient
            var patient = await patientRepository.GetCurrentPatient();
            var events = ViewData["events"];

            var patientID = Guid.Parse("FAC5316D-21ED-46C9-BF61-125D6EF3F3C6");

            var events1 = await healthCareTeamRepository.ReturnPatientApptListAsync(patientID);

            var viewModel = new PatientEventViewModel
            {
                Patient = patient,
                Events = (IEnumerable<Event>)ViewData["events1"]
            };

            return View(viewModel);
        }
    }
}
