namespace RoadMapBasedProjects.ViewModels
{
  public class ProductViewModel
  {
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string Type { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
  }
}
