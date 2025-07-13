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
            var patientID = Guid.Parse("1A0B71B3-61E4-4096-B647-70FAE91590DB");

            var patient = await planMyMDVisitDBContext.Patients
                .Include(p => p.HealthCareTeams)
                    .ThenInclude(h => h.Doctor)
                //.Include(p => p.User)
                .FirstOrDefaultAsync(p => p.Id == patientID);

            return patient;
        }
    }
}
