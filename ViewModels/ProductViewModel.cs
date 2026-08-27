using System.ComponentModel.DataAnnotations;

namespace RoadMapBasedProjects.ViewModels
{
  public class ProductViewModel
  {
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(0.01, 9999999)]
    public decimal Price { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    [Required]
    public string Type { get; set; } = string.Empty;

    [Required]
    [Url]
    public string Link { get; set; } = string.Empty;
  }
}
