﻿using System.ComponentModel.DataAnnotations;

namespace ESST6.Model;

public class LoginVM
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "Remember me")]
    public bool RememberMe { get; set; }
}
