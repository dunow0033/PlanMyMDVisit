using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public async Task<IActionResult> SelectSpecialty(int x)
        {
            return View();
        }
    }
}
