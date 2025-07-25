using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;
using System.Security.Claims;

namespace planMyMDVisit.Repositories
{
    public class HealthCareTeamRepository : IHealthCareTeamRepository
    {
        private readonly PlanMyMDVisitContext planMyMDVisitContext;
        private readonly IHttpContextAccessor httpContextAccessor;

        public HealthCareTeamRepository(PlanMyMDVisitContext planMyMDVisitContext, IHttpContextAccessor httpContextAccessor)
        {
            this.planMyMDVisitContext = planMyMDVisitContext;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<HealthCareTeam> CreateApptAsync(HealthCareTeam healthCareTeam)
        {
            await planMyMDVisitContext.HealthCareTeams.AddAsync(healthCareTeam);
            await planMyMDVisitContext.SaveChangesAsync();

            return healthCareTeam;
        }

        public async Task<HealthCareTeam[]> ReturnPatientApptListAsync(Guid patientID)
        {
            var healthCareTeams = await planMyMDVisitContext.HealthCareTeams.Where(hct => hct.PatientId == patientID).ToArrayAsync();

            return healthCareTeams;
        }

        public async Task<Guid?> GetPatientGuidFromPatient(Patient patient)
        {
            //var patientToFind = await planMyMDVisitContext.Patients.FirstOrDefaultAsync(p => p.Id == patient.Id);

            //var patientID = Guid.Parse("FAC5316D-21ED-46C9-BF61-125D6EF3F3C6");

            var httpContext = httpContextAccessor.HttpContext;

            var patientUserIDString = httpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrWhiteSpace(patientUserIDString) || !Guid.TryParse(patientUserIDString, out var patientUserId))
            {
                return null;
            }

            //if (!Guid.TryParse(patientIDString, out var patientId))
            //{
            //    return null;
            //}

            var patientToFind = await planMyMDVisitContext.Patients
                .Include(p => p.User)
                .Include(p => p.HealthCareTeams)
                    .ThenInclude(h => h.Doctor)
                .FirstOrDefaultAsync(p => p.UserId == patientUserId);


            //var patientToFind = await planMyMDVisitContext.Patients.FirstOrDefaultAsync(p => p.Id == patientID);

            return patientToFind.Id;
        }

        public async Task<Patient?> RetrieveHealthCareTeams(Guid userId)
        {
            return await planMyMDVisitContext.Patients
                .Include(p => p.HealthCareTeams)
                    .ThenInclude(hct => hct.Doctor)
                        .ThenInclude(d => d.User)
                .FirstOrDefaultAsync(p => p.UserId == userId);
        }

        public async Task<Patient?> ReturnPatient(Guid? patientId)
        {
            return await planMyMDVisitContext.Patients
                .Include(p => p.HealthCareTeams)
                    .ThenInclude(h => h.Doctor)
                        .ThenInclude(d => d.User)
                .FirstOrDefaultAsync(p => p.Id == patientId);
        }

        //public async Task<CreateApptRequest> CreateApptAsync(CreateApptRequest createApptRequest)
        //{
        //    await planMyMDVisitContext.HealthCareTeams.AddAsync(createApptRequest);
        //    await planMyMDVisitContext.SaveChangesAsync();

        //    return createApptRequest;
        //}
    }
}
