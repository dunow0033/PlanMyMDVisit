using Microsoft.AspNetCore.Mvc;

namespace planMyMDVisit.Controllers
{
    public class HealthCareTeamsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SelectSpecialty()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SelectSpecialty(int x)
        {
            return View();
        }
    }
}
