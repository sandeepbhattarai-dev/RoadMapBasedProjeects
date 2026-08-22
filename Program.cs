using RoadMapBasedProjects.DataBase;
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
builder.Services.AddSingleton<UsersTable>();
builder.Services.AddSingleton<UserHobbiesTable>();
builder.Services.AddSingleton<HobbiesTable>();
builder.Services.AddSingleton<ProductDataTable>();
builder.Services.AddSingleton<IAuthService, AuthService>();

builder.Services.AddScoped<IGetHobbies, GetHobbies>();
builder.Services.AddScoped<IRegistrationService, RegistrationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
