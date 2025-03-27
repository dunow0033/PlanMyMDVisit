using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly PlanMyMDVisitContext planMyMDVisitDBContext;

        public DoctorRepository(PlanMyMDVisitContext planMyMDVisitDBContext)
        {
            this.planMyMDVisitDBContext = planMyMDVisitDBContext;
        }

        public async Task<List<String>> GetSpecialties()
        {
            return await planMyMDVisitDBContext.Doctors
                .Select(d => d.Specialty).ToListAsync();
        }

        //public async Task<Doctor?> GetByIdAsync(Guid id)
        //{
        //    return await planMyMDVisitDBContext.Doctors
        //}
    }
}
