using System.ComponentModel.DataAnnotations.Schema;

namespace planMyMDVisit.Models.Domain
{
    public class HealthCareTeam
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public string? Specialty { get; set; }
        public DateTime Appointment { get; set; }

        //[ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }

        //[ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }
    }
}
