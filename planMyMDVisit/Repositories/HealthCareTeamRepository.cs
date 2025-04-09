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

        //public async Task<CreateApptRequest> CreateApptAsync(CreateApptRequest createApptRequest)
        //{
        //    await planMyMDVisitContext.HealthCareTeams.AddAsync(createApptRequest);
        //    await planMyMDVisitContext.SaveChangesAsync();

        //    return createApptRequest;
        //}
    }
}
