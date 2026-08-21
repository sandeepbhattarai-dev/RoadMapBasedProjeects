using RoadMapBasedProjects.Enums;
using System.ComponentModel.DataAnnotations;

namespace RoadMapBasedProjects.DTOs
{
  public class RegistrationDTO
  {
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
    [MinLength(3)]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Username is required.")]
    [StringLength(50, ErrorMessage = "Username cannot exceed 50 characters.")]
    [MinLength(3)]
    public string? UserName { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    [StringLength(150, ErrorMessage = "Email cannot exceed 150 characters.")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Phone number is required.")]
    [Phone(ErrorMessage = "Please enter a valid phone number.")]
    public string? PhoneNumber { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    [StringLength(
        100,
        MinimumLength = 8,
        ErrorMessage = "Password must be between 8 and 100 characters."
    )]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Please confirm your password.")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
    public string? ConfirmPassword { get; set; }

    [Required(ErrorMessage = "Please select a gender.")]
    public Gender? Gender { get; set; }

    [Required(ErrorMessage = "Please accept the terms and conditions.")]
    public bool IsTermsAgreed { get; set; }

    public List<int> HobbyId { get; set; } = new List<int>();
  }
}
