using Microsoft.EntityFrameworkCore;
using RoadMapBasedProjects.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// configure DbContext
string? ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (ConnectionString != null)
{
  builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(ConnectionString));
}
  var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseStaticFiles();

  app.MapControllerRoute(
      name: "default",
      pattern: "{controller=Home}/{action=Index}/{id?}");

  app.Run();
