using Microsoft.AspNetCore.Mvc;
using RoadMapBasedProjects.DTOs;
using RoadMapBasedProjects.Enums;
using RoadMapBasedProjects.Services;
using RoadMapBasedProjects.ViewModel;
using System.Security.Cryptography.X509Certificates;

namespace RoadMapBasedProjects.Controllers
{
  public class UserLoginController : Controller
  {

    private readonly IGetHobbies _gethobbiessv;
    private readonly IRegistrationService _registersv;

    public UserLoginController(IGetHobbies gethobbies, IRegistrationService register)
    {
      _gethobbiessv = gethobbies;
      _registersv = register;

    }
    //public UserLoginController()
    //{

    //}
    public IActionResult Login()
    {
      return View();
    }

    public IActionResult SignUp()
    {
      //fetch gender and hobbies and pass it to the
      IEnumerable<string> hobbyNames = _gethobbiessv.GetAllHobbies();

      Gender[] genders = Enum.GetValues<Genders>();

      RegistrationDTO registrationDTO = new RegistrationDTO();
      HobbyAndEnumviewModel viewModel = new HobbyAndEnumviewModel
      {
        HobbyNames = hobbyNames,
        Genders = genders,
        Registration = registrationDTO
      };

      return View(viewModel);
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
