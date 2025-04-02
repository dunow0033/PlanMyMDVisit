namespace planMyMDVisit.Models.Domain
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public ICollection<HealthCareTeam> HealthCareTeams { get; set; } = new List<HealthCareTeam>();
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();

        public static IQueryable<Doctor> Specialties(IQueryable<Doctor> doctors)
        {
            return doctors.Select(d => new Doctor { Specialty = d.Specialty }).Distinct().OrderBy(d => d.Specialty);
        }
    }
}
