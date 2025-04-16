using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;

namespace planMyMDVisit.Repositories
{
    public class HealthCareTeamRepository : IHealthCareTeamRepository
    {
        private readonly PlanMyMDVisitContext planMyMDVisitContext;

        public HealthCareTeamRepository(PlanMyMDVisitContext planMyMDVisitContext)
        {
            this.planMyMDVisitContext = planMyMDVisitContext;
        }

        public async Task<HealthCareTeam> CreateApptAsync(HealthCareTeam healthCareTeam)
        {
            await planMyMDVisitContext.HealthCareTeams.AddAsync(healthCareTeam);
            await planMyMDVisitContext.SaveChangesAsync();

            return healthCareTeam;
        }

        public async Task<Guid> GetPatientGuidFromPatient(Patient patient)
        {
            //var patientToFind = await planMyMDVisitContext.Patients.FirstOrDefaultAsync(p => p.Id == patient.Id);

            var patientID = Guid.Parse("2CEC381C-39EB-43B5-BE42-D2C9EACA1884");

            var patientToFind = await planMyMDVisitContext.Patients.FirstOrDefaultAsync(p => p.Id == patientID);

            return patientToFind.Id;
        }

        public async Task<Patient> ReturnPatient(Guid patientId)
        {
            return await planMyMDVisitContext.Patients
                .Include(p => p.HealthCareTeams)
                    .ThenInclude(h => h.Doctor)
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
