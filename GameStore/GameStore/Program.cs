var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapGet("games", () => "GTA V, The Witcher 3, Cyberpunk 2077");

app.Run();
