using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;
using planMyMDVisit.Repositories;

namespace planMyMDVisit.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly PlanMyMDVisitContext context;
        private readonly IDoctorRepository doctorRepository;

        public DoctorsController(IDoctorRepository doctorRepository, PlanMyMDVisitContext context)
        {
            this.doctorRepository = doctorRepository;
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string specialty)
        {
            List<Doctor> doctors;

            List<string> specialties = await doctorRepository.GetSpecialties();

            if (!string.IsNullOrWhiteSpace(specialty))
            {
                doctors = await context.Doctors
                    //.Include(d => d.User)
                    .Where(d => d.Specialty == specialty)
                    .ToListAsync();
            }
            else
            {
                doctors = await context.Doctors
                    //.Include(d => d.User)
                    .ToListAsync();
            }

            var doctorViewModel = new DoctorIndexViewModel
            {
                Doctors = doctors,
                SelectedSpecialty = specialty,

                SpecialtyListItems = specialties
                    .Distinct()
                    .OrderBy(s => s)
                    .Select(s => new SelectListItem { Text = s, Value = s })
                    //.Include(s => s.Specialty)
                    .ToList()
            };

            return View(doctorViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Show(Guid id)
        {
            var findDoctor = await doctorRepository.GetDoctorNameByID(id);
            var findDoctorSpecialty = await doctorRepository.GetDoctorSpecialtyByID(id);

            var doctor = new Doctor
            {
                Specialty = findDoctorSpecialty,
                Id = id,
            };

            return View(doctor);
        }
    }
}
