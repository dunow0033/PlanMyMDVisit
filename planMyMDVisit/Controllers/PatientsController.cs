using Microsoft.AspNetCore.Mvc;

namespace planMyMDVisit.Controllers
{
    public class PatientsController : Controller
    {
        //private readonly IMovieRepository movieRepository;

        public PatientsController()
        {
            //this.movieRepository = movieRepository;
        }

        [HttpGet]
        public IActionResult Show()
        {
            return View();
        }
    }
}
