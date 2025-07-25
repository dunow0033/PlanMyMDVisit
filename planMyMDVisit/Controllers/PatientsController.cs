using Microsoft.AspNetCore.Mvc;
using planMyMDVisit.Repositories;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;
using System.Security.Claims;
using planMyMDVisit.Utilities;

namespace planMyMDVisit.Controllers
{
    public class PatientsController : Controller
    {
        private readonly IPatientRepository patientRepository;
        private readonly IHealthCareTeamRepository healthCareTeamRepository;
        private readonly IHttpContextAccessor httpContextAccessor;

        public PatientsController(IPatientRepository patientRepository, 
            IHealthCareTeamRepository healthCareTeamRepository, 
            IHttpContextAccessor httpContextAccessor)
        {
            this.patientRepository = patientRepository;
            this.healthCareTeamRepository = healthCareTeamRepository;
            this.httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public async Task<IActionResult> Show()
        {
            //ViewData["events"] = new[]
            //{
            //    new Event{ Id = 1, Title = "Video for Marisa", StartDate = "19-06-2025" },
            //    new Event{ Id = 2, Title = "Preparation", StartDate = "12-06-2025" },
            //};

            var httpContext = httpContextAccessor.HttpContext;

            var patientUserIDString = Guid.Parse(httpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier));

            var patientTeams = await healthCareTeamRepository.RetrieveHealthCareTeams(patientUserIDString);

            //get patient
            var patient = await patientRepository.GetCurrentPatient();

            if (patient == null)
            {
                return NotFound("Current patient not found.");
            }
            //var events = ViewData["events"];

            var patientID = await patientRepository.GetPatientID(patient);

            var careTeams = Helpers.AllCareTeams(patientTeams);

            var events1 = await healthCareTeamRepository.ReturnPatientApptListAsync(patientID);

            var viewModel = new PatientEventViewModel
            {
                Patient = patient,
                Events = (IEnumerable<Event>)ViewData["events1"],
                HealthCareTeams = careTeams
            };

            return View(viewModel);
        }
    }
}
