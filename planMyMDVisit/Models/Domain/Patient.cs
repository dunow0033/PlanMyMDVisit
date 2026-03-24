using System.ComponentModel.DataAnnotations.Schema;

namespace planMyMDVisit.Models.Domain
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string? medicalRecord { get; set; }
        public string? testResults { get; set; }
        public string? medications { get; set; }
        public Guid UserId {  get; set; }
        public virtual User User { get; set; }
        public ICollection<HealthCareTeam> HealthCareTeams { get; set; } = new List<HealthCareTeam>();
        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //public String FullName()
        //{
        //    return FirstName + " " + LastName;
        //}
    }
}
