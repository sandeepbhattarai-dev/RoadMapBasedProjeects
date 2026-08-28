using Microsoft.EntityFrameworkCore;
using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

  }
}
