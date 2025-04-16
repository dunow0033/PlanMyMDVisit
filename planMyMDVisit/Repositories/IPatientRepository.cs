using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Repositories
{
    public interface IPatientRepository
    {
        Task<Patient> GetCurrentPatient();
    }
}
