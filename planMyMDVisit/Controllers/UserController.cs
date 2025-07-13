using Microsoft.AspNetCore.Mvc;

namespace planMyMDVisit.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Show()
        {
            return View();
        }
    }
}
