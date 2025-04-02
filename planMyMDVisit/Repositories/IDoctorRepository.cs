using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Repositories
{
    public interface IDoctorRepository
    {
        Task<List<string>> GetSpecialties();

        Task<List<Doctor>> GetDoctorsBySpecialty(string specialty);
    }
}
