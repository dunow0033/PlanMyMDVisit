﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly PlanMyMDVisitContext planMyMDVisitDBContext;

        public DoctorRepository(PlanMyMDVisitContext planMyMDVisitDBContext)
        {
            this.planMyMDVisitDBContext = planMyMDVisitDBContext;
        }

        public async Task<List<string>> GetSpecialties()
        {
            return await planMyMDVisitDBContext.Doctors
                .Select(d => d.Specialty).ToListAsync();
        }

        public async Task<Guid> GetCurrentPatientID()
        {
            var patientID = Guid.Parse("2CEC381C-39EB-43B5-BE42-D2C9EACA1884");

            var patient = await planMyMDVisitDBContext.Patients
                .Include(p => p.HealthCareTeams)
                .FirstOrDefaultAsync(p => p.Id == patientID);

            return patient.Id;
        }

        public async Task<string> GetPatientFullName()
        {
            var patientID = Guid.Parse("2CEC381C-39EB-43B5-BE42-D2C9EACA1884");

            var patient = await planMyMDVisitDBContext.Patients
                .Include(p => p.User)
                .FirstOrDefaultAsync(p => p.Id == patientID);

            if(patient == null)
            {
                throw new Exception("Patient not found");
            }

            return patient.User.FullName();
        }

        public async Task<List<Doctor>> GetDoctorsBySpecialty(string specialty)
        {
            return await planMyMDVisitDBContext.Doctors
                .Where(s => s.Specialty == specialty).ToListAsync();
        }

        public async Task<Guid> GetDoctorGuidByName(string doctorName)
        {
            return await planMyMDVisitDBContext.Doctors
                .Where(s => s.Name == doctorName)
                .Select(s => s.Id)
                .FirstOrDefaultAsync();
        }

        public async Task<string> GetDoctorNameByID(Guid? doctorId)
        {
            return await planMyMDVisitDBContext.Doctors
                .Where(s => s.Id == doctorId)
                .Select(s => s.Name)
                .FirstOrDefaultAsync();
        }

        public async Task<string> GetDoctorSpecialtyByID(Guid? doctorId)
        {
            return await planMyMDVisitDBContext.Doctors
                .Where(s => s.Id == doctorId)
                .Select(s => s.Specialty)
                .FirstOrDefaultAsync();
        }

        //public async Task<Doctor?> GetByIdAsync(Guid id)
        //{
        //    return await planMyMDVisitDBContext.Doctors
        //}
    }
}
