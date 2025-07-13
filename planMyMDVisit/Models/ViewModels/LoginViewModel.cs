using System.ComponentModel.DataAnnotations;

namespace planMyMDVisit.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string UserName {  get; set; }

        [Required]
        public string Password { get; set; }
    }
}
