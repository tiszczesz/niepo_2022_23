using Microsoft.EntityFrameworkCore;
using WebPortal_v1.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string connString = builder.Configuration.GetConnectionString("MySqlConn");
builder.Services.AddDbContext<PortalContext_3ti>(options =>
{
    options.UseMySql(connString, ServerVersion.AutoDetect(connString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
