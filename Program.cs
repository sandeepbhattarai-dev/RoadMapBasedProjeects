using RoadMapBasedProjects.DataBase;
using RoadMapBasedProjects.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<Usertbl>();
builder.Services.AddSingleton<CurrentUser>();
builder.Services.AddSingleton<Producttbl>();
builder.Services.AddScoped<IGetDataFromDb, GetDataFromDb>();
builder.Services.AddScoped<IProductServices, ProductServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
