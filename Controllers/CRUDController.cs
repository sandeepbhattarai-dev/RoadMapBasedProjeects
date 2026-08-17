using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Controllers
{
  public class CRUDController : Controller
  {

    private List<User> _user = new List<User>
      {
      new User { Id = 1, Name="Ron", Job="Doctor"},
      new User { Id = 2, Name="Roy", Job="Plumber"}
    };

    public IActionResult Index()
    {
      return View(_user);
    }

    public IActionResult IndexNew()
    {
      return View(_user);

    }


    public IActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public void Create(User details)
    {
      details.Id = _user.Count() + 1;
      _user.Add(details);
    }


    public IActionResult Edit(int Id)
    {
      User user = _user[Id];
      return View(user);
    }

    [HttpPost]
    public IActionResult Edit(User details)
    {
      _user.Add(details);
      return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int Id)
    {
      User user = _user[Id];
      return View(user);
    }

    [HttpPost]
    [Route("Delete")]
    public IActionResult DeleteConfirm(User details)
    {
      _user.Remove(details);
      return View("");
    }

  }
}