using Microsoft.AspNetCore.Http.HttpResults;
using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Repository
{
  public interface IProductRepository
  {
    // get all products
    public List<Product> GetProducts();

    //get one product by ID
    public Product GetProductById(string id);

    // create product
    public bool CreateNewProduct(Product product);
    
    // update product
    public bool UpdatePrduct(Product product);

    //delete product
    public bool DeleteProduct(Product product);
  }
}
