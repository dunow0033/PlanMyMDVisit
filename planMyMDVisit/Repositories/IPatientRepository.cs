using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Repositories
{
    public interface IPatientRepository
    {
        Task<Guid?> GetCurrentPatientID();

        Task<Patient> GetCurrentPatient();

        Task<Guid> GetPatientID(Patient patient);
    }
}
