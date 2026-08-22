using RoadMapBasedProjects.Enums;
namespace RoadMapBasedProjects.Models
{
  public class User
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public Genders? Gender { get; set; }

    public List<Hobbies> hobbies { get; set; } = new();
  }
}

