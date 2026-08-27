using RoadMapBasedProjects.Models;
using RoadMapBasedProjects.Services;

namespace RoadMapBasedProjects.Repository
{

  public class ProductRepository : IProductRepository
  {
    private readonly ReadFromFileService _readfile;
    public ProductRepository(ReadFromFileService readfile)
    {
      _readfile = readfile;
    }



    // get all products
    public List<Product> GetProducts()
    {
      return _readfile.FileRead();
    }

    //// get one product by ID
    //public Product GetProductById(string id)
    //{
    //  List<Product> products = GetProducts();
    //  foreach (var item in products)
    //  {
    //    if (item.Id == (id))
    //    {
    //      return item;
    //    }
    //  }
    //  return null;
    //}

    // create product
    public bool CreateNewProduct(Product product)
    {
      if (product != null)
      {
        List<Product> products = GetProducts();
        int count = products.Count;
        products.Add(product);
        if (products.Count > count)
        {
          if (_readfile.FileWrite(products))
          {
            return true;
          }
        }
      }

      return false;
    }

    // update product
    public bool UpdatePrduct(Product product)
    {
      List<Product> products = GetProducts();

      int index = products.FindIndex(p => p.Id == product.Id);

      if (index == -1)
      {
        return false; // Product does not exist
      }

      products[index] = product;

      _readfile.FileWrite(products);

      return true;
    }


    //delete product
    public bool DeleteProduct(Product product)
    {
      List<Product> products = GetProducts();

      int index = products.FindIndex(p => p.Id == product.Id);

      if (index == -1)
      {
        return false;
      }
      products.RemoveAt(index);
      _readfile.FileWrite(products);
      return true;
    }
  }
}
