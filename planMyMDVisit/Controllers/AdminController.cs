using Microsoft.AspNetCore.Mvc;
using planMyMDVisit.Repositories;

namespace planMyMDVisit.Controllers
{
    public class AdminController : Controller
    {
        private readonly IPatientRepository patientRepository;
        private readonly IHealthCareTeamRepository healthCareTeamRepository;
        private readonly IHttpContextAccessor httpContextAccessor;

        public AdminController(IPatientRepository patientRepository,
            IHealthCareTeamRepository healthCareTeamRepository,
            IHttpContextAccessor httpContextAccessor)
        {
            this.patientRepository = patientRepository;
            this.healthCareTeamRepository = healthCareTeamRepository;
            this.httpContextAccessor = httpContextAccessor;
        }

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
