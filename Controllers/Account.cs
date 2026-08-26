using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RoadMapBasedProjects.Models;
using RoadMapBasedProjects.Services;

namespace RoadMapBasedProjects.Controllers
{
  public class Account : Controller
  {
    private readonly IGetDataFromDb _dataFromDb;
    private readonly CurrentUser _currentUser;
    public Account(IGetDataFromDb datafromdb, CurrentUser currentuser)
    {
      _dataFromDb = datafromdb;
      _currentUser = currentuser;
    }

    public IActionResult Index(string something)
    {
      something = "something";
      return View((Object)something);
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
              return RedirectToAction("Index", "Home");
            }
            else
            {
              return View("Index", "fail to login");
            }
          }
        }
        else
        {
          return View("Index", "No user found");
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
        else{
          return View("Index", "try again");
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
         return View("Index", "could not log out");
      }
    }
  }
}
