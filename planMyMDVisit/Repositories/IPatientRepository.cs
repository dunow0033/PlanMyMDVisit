using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;

namespace planMyMDVisit.Repositories
{
    public interface IPatientRepository
    {
        Task<Guid?> GetCurrentPatientID();

        Task<Patient> GetCurrentPatient();

        Task<Guid> GetPatientID(Patient patient);

        Task<List<Patient>> GetAllPatients();

        Task<Patient> GetPatientById(Guid id);

        Task<Patient?> UpdateAsync(Guid id, EditUserViewModel editUserViewModel, string? NewPassword);

        Task<Patient?> DeleteAsync(Guid patientId);
    }
}
