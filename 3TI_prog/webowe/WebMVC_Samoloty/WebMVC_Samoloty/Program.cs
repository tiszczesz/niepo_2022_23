using Microsoft.EntityFrameworkCore;
using WebMVC_Samoloty.Models;
using System;
using WebMVC_Samoloty.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connString = builder.Configuration.GetConnectionString("MySqlConn");
builder.Services.AddDbContext<_3ti_prog_ark3odlotyContext>(options =>
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
    pattern: "{controller=Departures}/{action=Index}/{id?}");

app.Run();