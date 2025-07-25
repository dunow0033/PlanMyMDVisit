using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Models.ViewModels
{
    public class PatientEventViewModel
    {
        public Patient Patient { get; set; }
        
        public IEnumerable<Event> Events { get; set; }

        public ICollection<HealthCareTeam> HealthCareTeams { get; set; }
    }
}
