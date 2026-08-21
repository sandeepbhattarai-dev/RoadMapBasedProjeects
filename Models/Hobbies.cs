namespace RoadMapBasedProjects.Models
{
  public class Hobbies
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<User>? Users { get; set; } = new List<User>();

  }
}
