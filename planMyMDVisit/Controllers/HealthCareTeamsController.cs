using Microsoft.AspNetCore.Mvc;

namespace planMyMDVisit.Controllers
{
    public class HealthCareTeamsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SelectSpecialty()
        {
            return View();
        }
    }
}
