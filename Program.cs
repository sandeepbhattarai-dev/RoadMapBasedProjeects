using RoadMapBasedProjects.Services;

var builder = WebApplication.CreateBuilder(
  new WebApplicationOptions
  {
    Args = args,
    WebRootPath = "Xwwwroot"
  }
 );

// Add services to the container.
builder.Services.AddControllersWithViews();

// add the  singleton services
builder.Services.AddScoped<IGetHobbies, GetHobbies>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
