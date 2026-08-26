namespace RoadMapBasedProjects.Models
{
  public class ProductModel
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? Type { get; set; }
    public bool selected { get; set; }
    public string? Link { get; set; }
  }
}
