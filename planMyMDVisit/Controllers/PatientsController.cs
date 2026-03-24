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
        public async Task<IActionResult> Index()
        {
            var patients = await patientRepository.GetAllPatients();
            return View(patients);
        }

        public async Task<IActionResult> Show()
        {
            var httpContext = httpContextAccessor.HttpContext;
            var userIdString = httpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);

            // Check login FIRST before doing anything else
            if (string.IsNullOrWhiteSpace(userIdString))
            {
                TempData["Message"] = "You must log in first!!";
                return RedirectToAction("Login", "Account", new { message = "You must log in first!" });
            }

            // Safely parse the user ID
            if (!Guid.TryParse(userIdString, out var userId))
            {
                return BadRequest("Invalid user ID.");
            }

            // Get patient record
            var patient = await patientRepository.GetCurrentPatient();

            // If no patient record, this is a doctor — send to doctor dashboard
            if (patient == null)
            {
                return RedirectToAction("Dashboard", "Doctors");
            }

            var patientID = await patientRepository.GetPatientID(patient);
            var patientTeams = await healthCareTeamRepository.RetrieveHealthCareTeams(userId);
            var careTeams = Helpers.AllCareTeams(patientTeams);
            //var events1 = await healthCareTeamRepository.ReturnPatientApptListAsync(patientID);

            var viewModel = new PatientEventViewModel
            {
                Patient = patient,
                //Events = events1,
                HealthCareTeams = careTeams
            };

            return View(viewModel);
        }

    //    [HttpGet]
    //    public async Task<IActionResult> Show()
    //    {
    //        //ViewData["events"] = new[]
    //        //{
    //        //    new Event{ Id = 1, Title = "Video for Marisa", StartDate = "19-06-2025" },
    //        //    new Event{ Id = 2, Title = "Preparation", StartDate = "12-06-2025" },
    //        //};

    //        var httpContext = httpContextAccessor.HttpContext;

    //        var userIdString = httpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);

    //        //get patient
    //        var patient = await patientRepository.GetCurrentPatient();

    //        if (string.IsNullOrWhiteSpace(userIdString))
    //        {
    //            return RedirectToAction("Login", "Account");
    //        }

    //        // Safely parse the user ID
    //        if (!Guid.TryParse(userIdString, out var userId))
    //        {
    //            return BadRequest("Invalid user ID.");
    //        }

    //        var patientUserIDString = Guid.Parse(httpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier));

    //        var patientTeams = await healthCareTeamRepository.RetrieveHealthCareTeams(patientUserIDString);

    //        // Get patient record
    //        //var patient = await patientRepository.GetCurrentPatient();

    //        // If no patient record, this is a doctor — send to doctor dashboard
    //        if (patient == null)
    //        {
    //            return RedirectToAction("Dashboard", "Doctors");
    //        }

    //        if (patient == null)
    //        {
    //            return NotFound("Current patient not found.");
    //        }
    //        //var events = ViewData["events"];

    //        var patientID = await patientRepository.GetPatientID(patient);

    //        var careTeams = Helpers.AllCareTeams(patientTeams);

    //        var events1 = await healthCareTeamRepository.ReturnPatientApptListAsync(patientID);

    //        var viewModel = new PatientEventViewModel
    //        {
    //            Patient = patient,
    //            Events = (IEnumerable<Event>)ViewData["events1"],
    //            HealthCareTeams = careTeams
    //        };

    //        return View(viewModel);
    //    }
    }
}
