using Microsoft.AspNetCore.Mvc;
using RoadMapBasedProjects.DataBase;
using RoadMapBasedProjects.Models;
using RoadMapBasedProjects.Services;

namespace RoadMapBasedProjects.Controllers
{
  public class ProductController : Controller
  {
    private readonly IProductServices _productServices;
    public ProductController(IProductServices productServices)
    {
      _productServices = productServices; 
    }

    public IActionResult Index()
    {
      List<ProductModel> products;
      products = _productServices.GetProducts();
      return View(products);
    }
  }
}
