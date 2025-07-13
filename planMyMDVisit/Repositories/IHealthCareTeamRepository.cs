using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;

namespace planMyMDVisit.Repositories
{
    public interface IHealthCareTeamRepository
    {
        Task<HealthCareTeam> CreateApptAsync(HealthCareTeam healthCareTeam);
        Task<Patient> ReturnPatient(Guid patientId);

        Task<Guid> GetPatientGuidFromPatient(Patient patient);

        Task<HealthCareTeam[]> ReturnPatientApptListAsync(Guid patientID);
        //Task<CreateApptRequest> CreateApptAsync(CreateApptRequest createApptRequest);
    }
}
