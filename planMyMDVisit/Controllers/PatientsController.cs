using Microsoft.AspNetCore.Mvc;
using planMyMDVisit.Repositories;

namespace planMyMDVisit.Controllers
{
    public class PatientsController : Controller
    {
        private readonly IPatientRepository patientRepository;

        public PatientsController(IPatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Show()
        {
            //get patient
            var patient = await patientRepository.GetCurrentPatient();

            return View(patient);
        }
    }
}
