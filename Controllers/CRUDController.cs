using Microsoft.AspNetCore.Mvc;
using RoadMapBasedProjects.Data;
using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Controllers
{
  public class CRUDController : Controller
  {
    private readonly IUserRepo _users;

    public CRUDController(IUserRepo users)
    {
      _users = users;

    }

    public IActionResult Index()
    {
      var allUsers = _users.Read();

      return View(allUsers);
    }


    public IActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Create(User details)
    {

      _users.Create(details);
      
      return RedirectToAction("Index");
    }


    public IActionResult Edit(int Id)
    {
      User user = _users.GetById(Id);
      return View(user);
    }

    [HttpPost]
    public IActionResult Edit(User details)
    {
      bool result = _users.Edit(details);
      return result ? RedirectToAction(nameof(Index)) : NotFound();
    }

    public IActionResult Delete(int Id)
    {
      User user = _users.GetById(Id);
      return View(user);
    }

    [HttpPost]
    public IActionResult Delete(User details)
    {
      bool result = _users.Delete(details);
      return result ? RedirectToAction("Index") : NotFound();
    }

  }
}