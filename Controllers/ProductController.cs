using Microsoft.AspNetCore.Mvc;
using RoadMapBasedProjects.Repository;
using RoadMapBasedProjects.ViewModels;

namespace RoadMapBasedProjects.Controllers
{
  public class ProductController : Controller
  {
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
    public IActionResult InputForm()
    {
      return View();
    }
    [HttpPost]
    public IActionResult InputForm(ProductViewModel newproductdetails)
    {
      if (ModelState.IsValid) 
      {
        // add to db/file
      }
      return View(newproductdetails);
    }


    public IActionResult Buy()
    {
      return View();
    }
    public IActionResult AddToCart()
    {
      return View();
    }
  }
}
