using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly PlanMyMDVisitContext context;

        public DoctorsController(PlanMyMDVisitContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string specialty)
        {
            List<Doctor> doctors;

            if(!string.IsNullOrWhiteSpace(specialty))
            {
                doctors = await context.Doctors
                    .Include(d => d.User)
                    .Where(d => d.Specialty == specialty)
                    .ToListAsync();
            }
            else
            {
                doctors = await context.Doctors
                    .Include(d => d.User)
                    .ToListAsync();
            }

            return View(doctors);
        }

        public IActionResult Show()
        {
            return View();
        }
    }
}
