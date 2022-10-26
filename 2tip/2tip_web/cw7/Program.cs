var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
string firstname = "Roman";

app.UseStaticFiles();

app.MapGet("/", () => "<h1>Hello World! from 2TI</h1>");
app.MapGet("/date", () => $"Aktualny czas: {DateTime.Now.ToString()}");
app.MapGet("/info", () => $"Informacje {firstname}");

app.Run();
