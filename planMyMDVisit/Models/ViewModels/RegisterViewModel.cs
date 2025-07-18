﻿using System.ComponentModel.DataAnnotations;

namespace planMyMDVisit.Models.ViewModels;

public class RegisterViewModel
{
    [Required]
    public string UserName { get; set; }

    [Required]
    public string Firstname { get; set; }

    [Required]
    public string Lastname { get; set; }

    [Required]
    [Display(Name = "Role")]
    public string DoctorOrPatient { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}
