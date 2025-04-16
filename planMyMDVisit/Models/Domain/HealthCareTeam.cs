using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace planMyMDVisit.Models.Domain
{
    public class HealthCareTeam
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }

        [Required]
        public string Specialty { get; set; }
        public DateTime Appointment { get; set; }

        //[ForeignKey("PatientId")]
        [JsonIgnore]
        public virtual Patient Patient { get; set; }

        //[ForeignKey("DoctorId")]
        [JsonIgnore]
        public virtual Doctor Doctor { get; set; }
    }
}
