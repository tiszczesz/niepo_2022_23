using Microsoft.AspNetCore.Mvc;
using WebPortal_v1.Models;
using WebPortal_v1.ViewModels;

namespace WebPortal_v1.Controllers
{
    public class HomeController : Controller {
        private PortalContext_3ti _db;
        public LoginViewModel ViewModelm { get; set; }
        public HomeController(PortalContext_3ti db) {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index() {
            var users = _db.Uzytkownicies.ToList();
            ViewBag.all = users.Count;
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel vm) {

            return View(vm);
        }
    }
}
