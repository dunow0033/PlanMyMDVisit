﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace planMyMDVisit.Models.Domain
{
    public class Doctor
    {
        public Guid Id { get; set; }
        //public string Name { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public string Specialty { get; set; }

        //public string Email { get; set; }
        //public string UserName { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        //public string? Hospital { get; set; }
        //public string? Address { get; set; }
        //public string? City { get; set; }
        //public string? State { get; set; }
        //public string? Zipcode { get; set; }
        //public string? PhoneNumber { get; set; }
        //public string? Gender { get; set; }
        //public virtual User User { get; set; }
        //public Guid UserId { get; set; }
        public ICollection<HealthCareTeam> HealthCareTeams { get; set; } = new List<HealthCareTeam>();
        
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();

        //public String FullName()
        //{
        //    return $"Dr. {FirstName} {LastName}";
        //}

        //public static IQueryable<Doctor> Specialties(IQueryable<Doctor> doctors)
        //{
        //    return doctors.Select(d => new Doctor { Specialty = d.Specialty }).Distinct().OrderBy(d => d.Specialty);
        //}
    }
}
