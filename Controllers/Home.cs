using Microsoft.AspNetCore.Mvc;

namespace RoadMapBasedProjects.Controllers
{
  public class Home : Controller
  {

    public IActionResult Index()
    {
      return View();
    }
  }
}
