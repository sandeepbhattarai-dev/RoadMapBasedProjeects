using Microsoft.AspNetCore.Mvc;
using RoadMapBasedProjects.Repository;
using RoadMapBasedProjects.ViewModels;
using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Controllers
{
  public class ProductController : Controller
  {
    private static int _productCounter = 30;

    private static string GenerateProductId()
    {
      _productCounter++;
      return $"P{_productCounter:D3}";
    }

    private static Product GenerateProduct(ProductViewModel product)
    {
      return new Product()
      {
        Id = GenerateProductId(),
        Name = product.Name,
        Description = product.Description,
        Link = product.Link,
        Price = product.Price,
        selected = true,
        Type = product.Type
      };
    }
    private readonly IProductRepository _productRepository;
    public ProductController(IProductRepository repository)
    {
      _productRepository = repository;
    }


    public IActionResult Index()
    {
      // add new product and show entered product
      return View();
    }


    public IActionResult Buy() // Display the all Product
    {
      List<Product> products = _productRepository.GetProducts();
      if (products.Count > 0)
      {
        return View(products);
      }

      return NotFound();
        
    }




    public IActionResult AddNewProduct()    // just the view
    {

      return View();
    }

    [HttpPost]
    public IActionResult AddNewProduct(ProductViewModel product)   // 
    {
      Product newproduct = GenerateProduct(product);
      
      if (_productRepository.CreateNewProduct(newproduct))
      {
        return RedirectToAction("Index");
      }
      return View(product);
    }



    public IActionResult Edit(string id)
    {
      Product? editproduct = _productRepository.GetProductById(id);
      if (editproduct != null)
      {
        return View(new ProductViewModel()
        {
          Name = editproduct.Name,
          Description = editproduct.Description,
          Type = editproduct.Type,
          Link = editproduct.Link,
          Price = editproduct.Price,
        });
      }
      return NotFound();
    }


    [HttpPost]
    public IActionResult Edit(ProductViewModel product)
    {
      Product newproduct = GenerateProduct(product);
      if (_productRepository.UpdatePrduct(newproduct))
      {
         return RedirectToAction("Buy");
      }

      return NotFound();
      
    }

    public IActionResult Remove(string id)
    {
      Product? product = _productRepository.GetProductById(id);
      _productRepository.DeleteProduct(product);
      return RedirectToAction("Buy");
    }


























































  }
}
