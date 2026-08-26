using System.ComponentModel.DataAnnotations;

namespace RoadMapBasedProjects.Models
{
  public class UserDto
  {
      [Required]
      [StringLength(24, MinimumLength = 3, ErrorMessage = "Enter Valid UserName")]
      public string UserName { get; set; } = string.Empty;

      [Required]
      [DataType(DataType.Password)]
      public string Password { get; set; } = string.Empty;
  }
}