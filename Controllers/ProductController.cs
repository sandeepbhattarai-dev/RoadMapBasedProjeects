using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoadMapBasedProjects.Data;
using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Controllers
{
  public class ProductController : Controller
  {
    private readonly ApplicationDbContext _db;
    public ProductController(ApplicationDbContext db)
    {
      _db = db;
    }

    public async Task<IActionResult> Index()
    { // view all product and give edit and delete opttion
      List<Product> products = await _db.Products.ToListAsync();
      return View(products);
    }


    public async Task<IActionResult> Edit(string id)
    {// show a edit view and let user confirm edit
      Product editproduct = await _db.Products.FirstAsync(c => c.Id == id);
      return View(editproduct);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(Product editproduct)
    {// show the index with the chamfed edit as avail
      _db.Products.Update(editproduct);
      await _db.SaveChangesAsync();
      return RedirectToAction("Index");
    }

    public async Task<IActionResult> Delete(string id)
    {// show a edit view and let user confirm edit
      Product deleteProduct = await _db.Products.FirstAsync(c => c.Id == id);
      return View(deleteProduct);
    }
    [HttpPost, Route("Delete")]
    public async Task<IActionResult> ConfirmDelete(Product deleteProduct)
    {// show the index with the chamfed edit as avail
      _db.Products.Remove(deleteProduct);
      await _db.SaveChangesAsync();
      return RedirectToAction("Index");
    }



  }
}
