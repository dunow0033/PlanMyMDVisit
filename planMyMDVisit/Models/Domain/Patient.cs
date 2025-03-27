namespace planMyMDVisit.Models.Domain
{
    public class Patient
    {
        public Guid Id { get; set; }

        public User User { get; set; }

        public Guid UserId {  get; set; }

        public ICollection<HealthCareTeam> HealthCareTeams { get; set; } = new List<HealthCareTeam>();
        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
        public String FullName()
        {
            return User != null ? User.FullName() : null;
        }
    }
}
