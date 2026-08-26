using System.ComponentModel.DataAnnotations;

namespace RoadMapBasedProjects.Models
{
  public class Register
  {
    public int Id { get; set; }
    [Required]
    [StringLength(24, MinimumLength = 3, ErrorMessage = "Enter Valid UserName")]
    public string UserName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    [Compare("ConfirmPassword", ErrorMessage ="Please enter password and confirm password same")]
    public string Password { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = string.Empty;
  }
}
