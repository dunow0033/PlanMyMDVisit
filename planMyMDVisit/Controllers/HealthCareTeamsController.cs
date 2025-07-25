using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;
using planMyMDVisit.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Numerics;
using planMyMDVisit.Data;
using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Utilities;

namespace planMyMDVisit.Controllers
{
    [Route("HealthCareTeams")]
    public class HealthCareTeamsController : Controller
    {
        private readonly IDoctorRepository doctorRepository;
        private readonly IPatientRepository patientRepository;
        private readonly IHealthCareTeamRepository healthCareTeamRepository;

        public HealthCareTeamsController(IDoctorRepository doctorRepository, IPatientRepository patientRepository, IHealthCareTeamRepository healthCareTeamRepository)
        {
            this.doctorRepository = doctorRepository;
            this.patientRepository = patientRepository;
            this.healthCareTeamRepository = healthCareTeamRepository;
        }

        [HttpGet("Index")]
        //public async Task<IActionResult> Index(Patient patient)
        public async Task<IActionResult> Index(Guid patientId)
        {
            //var patientToFindGuid = await healthCareTeamRepository.GetPatientGuidFromPatient(patient);

            var patientToFind = await healthCareTeamRepository.ReturnPatient(patientId);

            if(patientToFind == null)
            {
                return NotFound("Patient not found.");
            }

            var careTeams = Helpers.AllCareTeams(patientToFind);

            var viewModel = new PatientEventViewModel
            {
                Patient = patientToFind,
                HealthCareTeams = careTeams
            };

            return View(viewModel);
        }

        [HttpGet("patientList/{patientID}")]
        public async Task<IActionResult> ReturnPatientApptListAsync(Guid patientID)
        {
            var healthCareTeams = await healthCareTeamRepository.ReturnPatientApptListAsync(patientID);

            var calendarEvents = healthCareTeams.Select(hct => new
            {
                title = hct.Specialty ?? "Appoinment",
                start = hct.Appointment.ToString("s")
            });

            return new JsonResult(calendarEvents);
        }

        [HttpGet("NewAppt")]
        public async Task<IActionResult> NewAppt()
        {
            var specialties = await doctorRepository.GetSpecialties();

            //var model = new SelectItemViewModel();
            //model.SpecialtySelectList = new List<SelectListItem>();

            //foreach(var specialty in specialties)
            //{
            //    model.SpecialtySelectList.Add(new SelectListItem { Text = specialty.    })
            //}

            var model = new CreateApptRequest
            {
                SpecialtySelectList = specialties
                    .Distinct()
                    .OrderBy(s => s)
                    .Select(s => new SelectListItem { Text = s.ToString(), Value = s.ToString() })
                    .ToList()
            };
            
            //ViewBag.SpecialtyList = new SelectList(specialties);

            return View(model);
        }

        [HttpGet("MakeNewAppt")]
        public IActionResult MakeNewAppt(CreateApptRequest createApptRequest)
        {
            var appt = new CreateApptRequest
            {
                Appointment = createApptRequest.Appointment,
                DoctorName = createApptRequest.DoctorName,
                Specialty = createApptRequest.Specialty
            };

            return View(appt);
        }

        [HttpPost("NewAppt")]
        public IActionResult NewAppt(CreateApptRequest createApptRequest)
        {
            var appt = new HealthCareTeam
            {
                Specialty = createApptRequest.Specialty,
            };

            //TempData["Specialty"] = appt.Specialty;

            return RedirectToAction("NewDrAndTime", new { specialty = appt.Specialty });
        }

        [HttpGet]
        [ActionName("NewDrAndTime")]
        //public async Task<IActionResult> NewDrAndTime(CreateApptRequest createApptRequest)
        public async Task<IActionResult> NewDrAndTime(string specialty)
        {
            //Console.WriteLine(TempData["Specialty"]);
            //var specialty = TempData.Peek("Specialty");
            
            //var specialty = TempData["Specialty"];

            //var specialtyItem = new SelectListItem
            //{
            //    Text = specialty,
            //    Value = specialty
            //};

            var doctors = await doctorRepository.GetDoctorsBySpecialty(specialty);
            //var doctors = await doctorRepository.GetDoctorsBySpecialty(specialtyItem);

            if (doctors == null | !doctors.Any())
            {
                ModelState.AddModelError("", "No doctor found for the selected specialty.");
                return View();
            }

            var model = new CreateApptRequest
            {
                Specialty = specialty.ToString(),
                SpecialtyDoctorList = doctors
                    //.OrderBy(s => s)
                    .Select(s => new SelectListItem { Text = s.User.FullName(), Value = s.Id.ToString() })
                    //.Include(s => s.Specialty)
                    .ToList()
            };

            //model.SpecialtyDoctorList = doctors.Select(d => new SelectListItem
            //{
            //    Text = d.Name,
            //    Value = d.Id.ToString()
            //}).ToList();

            //TempData["Specialty"] = createApptRequest.Specialty;
            //TempData["Appointment"] = createApptRequest.Appointment;

            //ViewBag.DoctorList = new SelectList(doctors, "Id", "Name");
            //ViewBag.DoctorList = new SelectList(doctors);

            return View(model);
        }

        [HttpPost]
        [ActionName("ConfirmAppt")]
        public async Task<IActionResult> ConfirmAppt(CreateApptRequest createApptRequest)
        {
            //Guid doctorId = await doctorRepository.GetDoctorGuidByName(createApptRequest.DoctorName);

            Guid? doctorId = null;

            if (createApptRequest.DoctorId != null)
            {
                doctorId = createApptRequest.DoctorId;
            }
            else
            {
                doctorId = await doctorRepository.GetDoctorGuidByName(createApptRequest.DoctorName);
            }

            Guid? tempPatientId = await patientRepository.GetCurrentPatientID();

            var hct = new HealthCareTeam
            {
                //Specialty = TempData["Specialty"]?.ToString(),
                Specialty = createApptRequest.Specialty,
                DoctorId = doctorId,
                Patient = createApptRequest.Patient,
                Appointment = createApptRequest.Appointment,
                PatientId = tempPatientId
            };

            var appt = new CreateApptRequest
            {
                Specialty = hct.Specialty,
                DoctorId = hct.DoctorId,
                Patient = hct.Patient,
                Appointment = hct.Appointment,
                PatientId = hct.PatientId,
                FullName = await doctorRepository.GetPatientFullName(),
                DoctorName = await doctorRepository.GetDoctorNameByID(hct.DoctorId)
            };

            Console.WriteLine("Patient FullName " + appt.FullName);

            await healthCareTeamRepository.CreateApptAsync(hct);

            return View(appt);
        }

        //[HttpPost]
        //[ActionName("ConfirmAppt2")]
        //public async Task<IActionResult> ConfirmAppt2(CreateApptRequest createApptRequest)
        //{
        //    //Guid doctorId = await doctorRepository.GetDoctorGuidByName(createApptRequest.DoctorName);
        //    Guid doctorId = await doctorRepository.GetDoctorGuidByName(createApptRequest.DoctorName);

        //    Guid tempPatientId = await doctorRepository.GetCurrentPatientID();

        //    var hct = new HealthCareTeam
        //    {
        //        //Specialty = TempData["Specialty"]?.ToString(),
        //        Specialty = createApptRequest.Specialty,
        //        DoctorId = doctorId,
        //        Patient = createApptRequest.Patient,
        //        Appointment = createApptRequest.Appointment,
        //        PatientId = tempPatientId
        //    };

        //    var appt = new CreateApptRequest
        //    {
        //        Specialty = hct.Specialty,
        //        DoctorId = hct.DoctorId,
        //        Patient = hct.Patient,
        //        Appointment = hct.Appointment,
        //        PatientId = hct.PatientId,
        //        FullName = await doctorRepository.GetPatientFullName(),
        //        DoctorName = await doctorRepository.GetDoctorNameByID(hct.DoctorId)
        //    };

        //    Console.WriteLine("Patient FullName " + appt.FullName);

        //    await healthCareTeamRepository.CreateApptAsync(hct);

        //    return View("ConfirmAppt", appt);
        //}
    }
}
