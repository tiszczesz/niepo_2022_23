using Microsoft.AspNetCore.Mvc;
using Ogloszenia2MVC.Models;
using System.Diagnostics;
using Ogloszenia2MVC.Data;

namespace Ogloszenia2MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyAppContext _db;

        public HomeController(ILogger<HomeController> logger,MyAppContext db) {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}