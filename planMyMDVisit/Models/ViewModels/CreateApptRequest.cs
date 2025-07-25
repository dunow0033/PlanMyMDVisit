﻿using Microsoft.AspNetCore.Mvc.Rendering;
using planMyMDVisit.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace planMyMDVisit.Models.ViewModels
{
    public class CreateApptRequest
    {
        public string Specialty { get; set; }
        public Guid? PatientId { get; set; }
        public string DoctorName { get; set; }
        public Guid? DoctorId { get; set; }
        public DateTime Appointment { get; set; }
        public Patient Patient { get; set; }
        public string FullName { get; set; }
        public List<SelectListItem> SpecialtySelectList { get; set; }
        public List<SelectListItem> SpecialtyDoctorList { get; set; }
    }
}
