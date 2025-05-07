using Microsoft.AspNetCore.Mvc;

namespace planMyMDVisit.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show()
        {
            return View();
        }
    }
}
