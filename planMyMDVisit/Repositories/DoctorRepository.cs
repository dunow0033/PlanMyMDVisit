using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;
using System.Security.Claims;

namespace planMyMDVisit.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly PlanMyMDVisitContext planMyMDVisitDBContext;
        private readonly IHttpContextAccessor httpContextAccessor;

        public DoctorRepository(PlanMyMDVisitContext planMyMDVisitDBContext, IHttpContextAccessor httpContextAccessor)
        {
            this.planMyMDVisitDBContext = planMyMDVisitDBContext;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<string>> GetSpecialties()
        {
            return await planMyMDVisitDBContext.Doctors
                .Select(d => d.Specialty).ToListAsync();
        }

        public async Task<Guid> GetCurrentPatientID()
        {
            //var patientID = Guid.Parse("E8303783-C127-463C-9120-3AB1EFCA7BDB");
            var httpContext = httpContextAccessor.HttpContext;

            var patientIDString = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            //if (!Guid.TryParse(patientIDString, out var patientId))
            //{
            //    return null;
            //}

            var patient = await planMyMDVisitDBContext.Patients
                .Include(p => p.HealthCareTeams)
                .FirstOrDefaultAsync(p => p.Id.ToString() == patientIDString);

            return patient.Id;
        }

        public async Task<string> GetPatientFullName()
        {
            //var patientID = Guid.Parse("E8303783-C127-463C-9120-3AB1EFCA7BDB");

            var httpContext = httpContextAccessor.HttpContext;

            var patientUserIDString = httpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrWhiteSpace(patientUserIDString) || !Guid.TryParse(patientUserIDString, out var patientUserId))
            {
                return null;
            }

            var patient = await planMyMDVisitDBContext.Patients
                //.AsAsyncEnumerable()
                .Include(p => p.User)
                .FirstOrDefaultAsync(p => p.UserId == patientUserId);

            if(patient == null)
            {
                throw new Exception("Patient not found");
            }

            return patient.User.FullName();
        }

        public async Task<List<Doctor>> GetDoctorsBySpecialty(string specialty)
        {
            var doctors = await planMyMDVisitDBContext.Doctors
                .Include(d  => d.User)
                .Where(s => s.Specialty.ToLower() == specialty.ToLower()).ToListAsync();

            return doctors;
        }

        public async Task<Guid?> GetDoctorGuidByName(string doctorName)
        {
            var doctors = await planMyMDVisitDBContext.Doctors.ToListAsync();
            var doctor = doctors.FirstOrDefault(d => d.User.FullName() == doctorName);

            return doctor?.Id;

            //return await planMyMDVisitDBContext.Doctors
            //    .Where(s => s.FullName() == doctorName)
            //    .Select(s => s.Id)
            //    .FirstOrDefaultAsync();
        }

        public async Task<string> GetDoctorNameByID(Guid? doctorId)
        {
            return await planMyMDVisitDBContext.Doctors
                .Where(s => s.Id == doctorId)
                .Select(s => s.User.FullName())
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
