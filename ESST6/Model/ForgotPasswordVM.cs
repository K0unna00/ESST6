using System.ComponentModel.DataAnnotations;

namespace ESST6.Model;

public class ForgotPasswordVM
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
