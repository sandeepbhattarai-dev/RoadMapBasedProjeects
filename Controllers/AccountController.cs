using Microsoft.AspNetCore.Mvc;
using RoadMapBasedProjects.Models;
using RoadMapBasedProjects.Services;

namespace RoadMapBasedProjects.Controllers
{
  public class AccountController : Controller
  {
    private readonly IGetDataFromDb _dataFromDb;
    private readonly CurrentUser _currentUser;
    public AccountController(IGetDataFromDb datafromdb, CurrentUser currentuser)
    {
      _dataFromDb = datafromdb;
      _currentUser = currentuser;
    }

    public IActionResult Index()
    {
      if (_currentUser.currentuser())
      {
        return View();
      }
      else
      {
        return RedirectToAction("Login");
      }
      
    }

    /* -------------Login------------------*/
    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Login(UserDto user)
    {
      if (ModelState.IsValid)
      {
        if (_dataFromDb.IsUser(user.UserName))
        {
          if (_dataFromDb.CheckPassword(user.Password))
          {
            if (_currentUser.Login(user.UserName))
            {
              return RedirectToAction("Index");
            }
            else
            {
              return View();
            }
          }
        }
        else
        {
          return View();
        }

      }
      return View(user);
    }




    /* -------------Register------------------*/

    public IActionResult Register()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Register(Register register)
    {
      if (ModelState.IsValid)
      {
        if (_dataFromDb.CreateNewUser(register))
        {
          return RedirectToAction("Login");
        }
        else
        {
          return View();
        }
      }
      else
      {
        return View(register);
      }
    }










    /* -------------Loggout------------------*/
    public IActionResult Logout()
    {
      if (_currentUser.logout())
      {
        return RedirectToAction("Index", "Home");
      }
      else
      {
        return View();
      }
    }
  }
}
