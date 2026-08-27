namespace RoadMapBasedProjects.Models
{
  public class Product
  {
    public required string Id { get; set; } = string.Empty;
    public required string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string Type { get; set; } = string.Empty;
    public bool selected { get; set; }
    public string Link { get; set; } = string.Empty;
  }
}
