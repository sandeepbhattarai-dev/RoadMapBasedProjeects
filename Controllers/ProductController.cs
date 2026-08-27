using Microsoft.AspNetCore.Mvc;
using RoadMapBasedProjects.DataBase;
using RoadMapBasedProjects.Models;
using RoadMapBasedProjects.Services;

namespace RoadMapBasedProjects.Controllers
{
  public class ProductController : Controller
  {
    private readonly IProductServices _productServices;
    private readonly CurrentUser _currentuser;
    public ProductController(IProductServices productServices, CurrentUser currentuser)
    {
      _productServices = productServices;
      _currentuser = currentuser;
    }

    public IActionResult Index()
    {
      if (_currentuser.currentuser())
      {
        List<ProductModel> products;
        products = _productServices.GetProducts();
        return View(products);
      }
      return RedirectToAction("Login", "Account");
      
    }
  }
}
