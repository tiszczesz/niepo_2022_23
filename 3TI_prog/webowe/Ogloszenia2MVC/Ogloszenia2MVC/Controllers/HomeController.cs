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

        public IActionResult Index() {
            List<User> users = _db.AllUzytkownicy.ToList();
            return View(users);
        }

        [HttpGet]
        public IActionResult AddNew() {
            var user = new User();
            user.Ogloszenias = null;
            return View(user);
        }

        [HttpPost]
        public IActionResult AddNew(User user) {
            if (!ModelState.IsValid) {
                
                return View();
            }
            var result = user;
            _db.AllUzytkownicy.Add(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}