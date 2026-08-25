using RoadMapBasedProjects.Models;
using Microsoft.AspNetCore.Mvc;

namespace RoadMapBasedProjects.Controllers
{
  public class Account : Controller
  {
    public IActionResult Login()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Login(User user)
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Register(Register register)
    {
      return View();
    }
    [HttpPost]
    public IActionResult Logout(User user)
    {
      return View();
    }
  }
}
