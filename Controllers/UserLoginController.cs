using Microsoft.AspNetCore.Mvc;
using RoadMapBasedProjects.DTOs;

namespace RoadMapBasedProjects.Controllers
{
  public class UserLoginController : Controller
  {

    private readonly RegistrationDTO registration = new RegistrationDTO();
    public IActionResult Login()
    {
      return View();
    }

    public IActionResult SignUp()
    {

      return View();
    }
    [HttpPost]
    public IActionResult SignUp(RegistrationDTO userRegistration)
    {
      if (!ModelState.IsValid)
      {
        return View();
      }
      
      return RedirectToAction("Login");
    }
  }
}
