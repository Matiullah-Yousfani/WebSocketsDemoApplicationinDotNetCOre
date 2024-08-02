var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var name = "Mutiullah!";
app.MapGet("/", () => $"Hello {name}");

app.Run();
