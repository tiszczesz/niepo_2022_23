### Tworzenie pustego projektu
```console
dotnet new web -o nazwaProjektu
```

### W pliku Program.cs
1. Ustawiamy używanie MVC
```cs
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();// tutaj dodajemy obsługę MVC
var app = builder.Build();

app.UseStaticFiles();// włączamy obsługę plików statycznych
app.MapControllerRoute(// ustawiamy endpoints
    name: "default",//
    pattern: "{controller=First}/{action=Index}/{id?}"//
);//

app.Run();
```
### Dla wygody dodajemy Vieimports
```console
dotnet new viewimports // w katalogy Views
```

### dodajemy katalog wwwroot oraz Controllers oraz Views
### Tworzymy nowy kontroler jako klasę didziczącą z Controller
### Wstawiamy do kontrolera akcje jako metody publiczne
### W katalogu Views dodajem y katalog z nazwą kontrolera oraz widoki dla akcji

