using RoadMapBasedProjects.DataBase;
using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Services
{
  public class ProductServices : IProductServices
  {
    private readonly Producttbl _productservice;
    public ProductServices(Producttbl productservice)
    {
      _productservice = productservice;
    }
    public List<ProductModel> GetProducts()
    {
      return _productservice.Products;
    }
  }
}
