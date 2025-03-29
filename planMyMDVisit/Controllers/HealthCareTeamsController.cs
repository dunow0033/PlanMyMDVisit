using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;
using planMyMDVisit.Repositories;

namespace planMyMDVisit.Controllers
{
    public class HealthCareTeamsController : Controller
    {
        private readonly IDoctorRepository doctorRepository;

        public HealthCareTeamsController(IDoctorRepository doctorRepository)
        {
            this.doctorRepository = doctorRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SelectSpecialty()
        {
            var specialties = await doctorRepository.GetSpecialties();
            ViewBag.SpecialtyList = new SelectList(specialties);

            return View();
        }

        [HttpPost]
        public IActionResult NewAppt(CreateHealthCareTeam createHealthCareTeam)
        {
            return RedirectToAction("New");
        }

        [HttpGet]
        [ActionName("New")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ActionName("ScheduleAppt")]
        public IActionResult ScheduleAppt()
        {
            return View();
        }
    }
}
