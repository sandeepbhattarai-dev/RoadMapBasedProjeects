using Microsoft.AspNetCore.Mvc;
using RoadMapBasedProjects.DTOs;

namespace RoadMapBasedProjects.Controllers
{
  public class UserLoginController : Controller
  {

    public UserLoginController()
    {
      
    }
    public IActionResult Login()
    {
      return View();
    }

    public IActionResult SignUp()
    {
      //fetch gender and hobbies and pass it to the

      return View();
    }
    [HttpPost]
    public IActionResult SignUp(RegistrationDTO userRegistration)
    {
      if (!ModelState.IsValid)
      {
        return View();
      }

      if (false) // calls the registration service and pass the userRegistration data
      {

      }
      
      return RedirectToAction("Login");
    }
  }
}
