using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;
using System.Net.Http;
using System.Security.Claims;

namespace planMyMDVisit.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PlanMyMDVisitContext planMyMDVisitDBContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PatientRepository(PlanMyMDVisitContext planMyMDVisitDBContext, IHttpContextAccessor httpContextAccessor)
        {
            this.planMyMDVisitDBContext = planMyMDVisitDBContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Guid?> GetCurrentPatientID()
        {
            //var patientID = Guid.Parse("E8303783-C127-463C-9120-3AB1EFCA7BDB");
            var httpContext = _httpContextAccessor.HttpContext;

            var patientUserIDString = httpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrWhiteSpace(patientUserIDString) || !Guid.TryParse(patientUserIDString, out var patientUserId))
            {
                return null;
            }

            //if (!Guid.TryParse(patientIDString, out var patientId))
            //{
            //    return null;
            //}

            var patient = await planMyMDVisitDBContext.Patients
                .Include(p => p.User)
                .Include(p => p.HealthCareTeams)
                    .ThenInclude(h => h.Doctor)
                .FirstOrDefaultAsync(p => p.UserId == patientUserId);

            //var patient = await planMyMDVisitDBContext.Patients
            //    .Include(p => p.User)
            //    .Include(p => p.HealthCareTeams)
            //        .ThenInclude(h => h.Doctor)
            //    .FirstOrDefaultAsync(p => p.UserId == userId);

            return patient.Id;
        }

        public async Task<Patient> GetCurrentPatient()
        {
            //string userId;

            var httpContext = _httpContextAccessor.HttpContext;

            //if(httpContext?.User?.Identity?.IsAuthenticated != true)
            //{
            //    return null;
            //}

            //if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            //{
                //userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userIdString = httpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);

            var patientIdString = planMyMDVisitDBContext.Patients.Where(p => p.UserId.ToString() == userIdString);

            //string userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            //}

            if (string.IsNullOrWhiteSpace(userIdString) || !Guid.TryParse(userIdString, out var userId))
            {
                return null;
            }

            //if (!Guid.TryParse(patientIdString, out var userId))
            //{
            //    return null;
            //}

            //var patientID = Guid.Parse("1A0B71B3-61E4-4096-B647-70FAE91590DB");

            //userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var patient = await planMyMDVisitDBContext.Patients
                .Include(p => p.User)
                .Include(p => p.HealthCareTeams)
                    .ThenInclude(h => h.Doctor)
                .FirstOrDefaultAsync(p => p.UserId == userId);
           
            //.ThenInclude(p => p.User)
            //.FirstOrDefaultAsync(p => p.Id == userId);

            return patient;
        }

        public async Task<Guid> GetPatientID(Patient patient)
        {
            if(patient == null)
            {
                throw new ArgumentNullException(nameof(patient), "Patient is null");
            }

            var patientToFind = await planMyMDVisitDBContext.Patients.FirstOrDefaultAsync(p => p.Id == patient.Id);

            if (patientToFind == null)
            {
                throw new Exception("Patient not found in database");
            }

            return patientToFind.Id;
        }
    }
}
