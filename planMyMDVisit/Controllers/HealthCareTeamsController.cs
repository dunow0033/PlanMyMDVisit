﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;
using planMyMDVisit.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Numerics;

namespace planMyMDVisit.Controllers
{
    public class HealthCareTeamsController : Controller
    {
        private readonly IDoctorRepository doctorRepository;
        private readonly IHealthCareTeamRepository healthCareTeamRepository;

        public HealthCareTeamsController(IDoctorRepository doctorRepository, IHealthCareTeamRepository healthCareTeamRepository)
        {
            this.doctorRepository = doctorRepository;
            this.healthCareTeamRepository = healthCareTeamRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
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
                    .Select(s => new SelectListItem { Text = s, Value = s })
                    .ToList()
            };
            
            //ViewBag.SpecialtyList = new SelectList(specialties);

            return View(model);
        }

        [HttpPost]
        public IActionResult NewAppt(CreateApptRequest createApptRequest)
        {
            var appt = new HealthCareTeam
            {
                Specialty = createApptRequest.Specialty,
            };

            TempData["Specialty"] = appt.Specialty;

            return RedirectToAction("NewDrAndTime");
        }

        [HttpGet]
        [ActionName("NewDrAndTime")]
        public async Task<IActionResult> NewDrAndTime(CreateApptRequest createApptRequest)
        {
            //Console.WriteLine(TempData["Specialty"]);
            var specialty = TempData["Specialty"];

            //var doctors = await doctorRepository.GetDoctorsBySpecialty(createApptRequest.Specialty);
            var doctors = await doctorRepository.GetDoctorsBySpecialty(specialty.ToString());

            if (doctors == null | !doctors.Any())
            {
                ModelState.AddModelError("", "No doctor found for the selected specialty.");
                return View();
            }

            var model = new CreateApptRequest
            {
                SpecialtyDoctorList = doctors
                    //.OrderBy(s => s)
                    .Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() })
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
            Guid doctorId = createApptRequest.DoctorId;

            Guid tempPatientId = await doctorRepository.GetCurrentPatientID();

            var hct = new HealthCareTeam
            {
                Specialty = TempData["Specialty"]?.ToString(),
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
    }
}
