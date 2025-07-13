using System.ComponentModel.DataAnnotations.Schema;

namespace planMyMDVisit.Models.Domain
{
    public class Patient
    {
        public Guid Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Email { get; set; }
        //public string UserName {  get; set; }
        public Guid UserId {  get; set; }
        public virtual User User { get; set; }

        //[ForeignKey("UserId")]
        //public virtual User User { get; set; }
        //public Guid UserId {  get; set; }
        
        public ICollection<HealthCareTeam> HealthCareTeams { get; set; } = new List<HealthCareTeam>();
        
        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
        //public String FullName()
        //{
        //    return FirstName + " " + LastName;
        //}
    }
}
