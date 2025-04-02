using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;

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
    }
}
