using planMyMDVisit.Models.Domain;
using planMyMDVisit.Repositories;

namespace planMyMDVisit.Utilities
{
    internal static class Helpers
    {
        internal static ICollection<HealthCareTeam> TwoLatestCareTeams(Patient patient)
        {
            return patient.HealthCareTeams.OrderByDescending(x => x.Appointment).Take(2).ToList();
        }

        internal static ICollection<HealthCareTeam> AllCareTeams(Patient patient)
        {
            return patient.HealthCareTeams.OrderByDescending(x => x.Appointment).ToList();
        }
    }
}
