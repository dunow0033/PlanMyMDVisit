using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;

namespace planMyMDVisit.Repositories
{
    public interface IHealthCareTeamRepository
    {
        Task<HealthCareTeam> CreateApptAsync(HealthCareTeam healthCareTeam);
        //Task<CreateApptRequest> CreateApptAsync(CreateApptRequest createApptRequest);
    }
}
