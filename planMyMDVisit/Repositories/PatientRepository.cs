using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PlanMyMDVisitContext planMyMDVisitDBContext;

        public PatientRepository(PlanMyMDVisitContext planMyMDVisitDBContext)
        {
            this.planMyMDVisitDBContext = planMyMDVisitDBContext;
        }

        public async Task<Patient> GetCurrentPatient()
        {
            var patientID = Guid.Parse("2CEC381C-39EB-43B5-BE42-D2C9EACA1884");

            var patient = await planMyMDVisitDBContext.Patients
                .Include(p => p.HealthCareTeams)
                    .ThenInclude(h => h.Doctor)
                .Include(p => p.User)
                .FirstOrDefaultAsync(p => p.Id == patientID);

            return patient;
        }
    }
}
