using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;

namespace planMyMDVisit.Repositories
{
    public interface IHealthCareTeamRepository
    {
        Task<HealthCareTeam> CreateApptAsync(HealthCareTeam healthCareTeam);
        Task<Patient> ReturnPatient(Guid? patientId);

        Task<Guid?> GetPatientGuidFromPatient(Patient patient);

        Task<Patient> RetrieveHealthCareTeams(Guid userId);

        Task<HealthCareTeam[]> ReturnPatientApptListAsync(Guid patientID);
        //Task<CreateApptRequest> CreateApptAsync(CreateApptRequest createApptRequest);

        Task<HealthCareTeam?> GetHealthCareTeamById(Guid id);
        Task<HealthCareTeam?> UpdateHealthCareTeam(HealthCareTeam healthCareTeam);
        Task<bool> DeleteHealthCareTeam(Guid id);
    }
}
