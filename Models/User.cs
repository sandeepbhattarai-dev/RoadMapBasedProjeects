using System.ComponentModel.DataAnnotations;

namespace RoadMapBasedProjects.Models
{
  public class User
  {
    public User() { }
    [Required]
    public int Id { get; set; }

    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(24, MinimumLength =3,ErrorMessage ="Enter Valid UserName")]
    public string UserName { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
  }
}
