using Microsoft.AspNetCore.Mvc;
using RoadMapBasedProjects.Models;
using System.Collections.Generic;

namespace RoadMapBasedProjects.Controllers
{
  public class CRUDController : Controller
  {

    public List<User> _user = new List<User>
      {
      new User { Id = 1, Name="Ron"},
      new User { Id = 2, Name="Roy"}
    };

    public IActionResult Index()
    {
      return View(_user);
    }


    public IActionResult Create()
    {
      return View();
    }
    //  [HttpPost]
    //  public IActionResult Create(string country = "don", string capital = "key")
    //  {

    //  }

    //  public IActionResult Edit(string country)
    //  {


    //  }

    //  [HttpPost]
    //  public IActionResult Edit(string country = "don", string capital = "key")
    //  {

    //  }


    //}
  }
}