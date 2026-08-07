using Microsoft.AspNetCore.Mvc;

namespace RoadMapBasedProjects.Controllers
{
    public class CustomConfigurationController : Controller
    {
        private readonly IConfiguration _configuration;

        public CustomConfigurationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            string? publickey = _configuration["keys:publicKey"];
            string? mysecret = _configuration["keys:mysupersecret:mysecret"];
            string? myothersecret = _configuration["keys:mysupersecret:myothersecret"];
            return View(new{ publickey, mysecret, myothersecret });
        }
    }
}
