using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public List<Kurs> MojeKursy { get; set; } = MojeDane.NazwyKursow();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() {
            //MojeKursy = MojeDane.NazwyKursow();
            return View(MojeKursy);
        }

        public IActionResult Kurs(int id) {
            Kurs k1 = MojeKursy.Find(k=>k.Id==id);
            return View(k1);
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