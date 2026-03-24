using System.ComponentModel.DataAnnotations;

namespace planMyMDVisit.Models.ViewModels
{
    public class EditPatientViewModel
    {
        public Guid Id { get; set; }
        public string? medicalRecord { get; set; }
        public string? testResults { get; set; }
        public string? medications { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
