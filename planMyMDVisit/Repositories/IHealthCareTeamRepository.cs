using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Repositories
{
    public interface IHealthCareTeamRepository
    {
        Task<HealthCareTeam> CreateApptAsync(HealthCareTeam healthCareTeam);
    }
}
