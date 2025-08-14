using planMyMDVisit.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace planMyMDVisit.Models.ViewModels
{
    public class EditUserViewModel
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Patient? Patient { get; set; }

        [Required]
        public string? FirstName { get; set; } = "";

        [Required]
        public string? LastName { get; set; } = "";

        [Required]
        public string? UserName { get; set; } = "";

        [Required]
        public string? Email { get; set; } = "";

        [DataType(DataType.Password)]
        public string? NewPassword { get; set; }
    }
}
