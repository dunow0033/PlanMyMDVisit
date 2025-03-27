using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Repositories
{
    public interface IDoctorRepository
    {
        Task<List<String>> GetSpecialties();
    }
}
