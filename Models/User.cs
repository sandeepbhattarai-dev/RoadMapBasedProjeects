namespace RoadMapBasedProjects.Models
{
  public class User
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }
    public string? UserId { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Gender { get; set; }

    public List<Hobbies> hobbies { get; set; } = new();
  }
}
