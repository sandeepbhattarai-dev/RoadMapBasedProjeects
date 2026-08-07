using Microsoft.AspNetCore.Mvc;

namespace RoadMapBasedProjeects.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
