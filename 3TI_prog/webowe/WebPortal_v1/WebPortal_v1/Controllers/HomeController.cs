using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
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
            ViewBag.model = false;
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel vm) {
            if (ModelState.IsValid) {
                ViewBag.model = true;
                var users = _db.Uzytkownicies.ToList();
                ViewBag.all = users.Count;
                ViewBag.correct = true;
                string login = vm.Login;
                int row = _db.Uzytkownicies.Count(u => u.Login == login);
                if (row > 0) {
                    ViewBag.result = "Login OK";
                    var user = _db.Uzytkownicies.FirstOrDefault(u => u.Login == login);
                    
                    if (user != null && user.Haslo == getStringFromSHA1(vm.Password)) {
                        ViewBag.isOKPswd = true;
                        var dane = _db.Danes.FirstOrDefault(d => d.Id == user.Id);
                        if (dane != null) {
                            ViewBag.dane = dane;
                            ViewBag.year = DateTime.Now.Year - dane.RokUrodz;
                        }
                    }
                    else {
                        ViewBag.isOKPswd = false;
                    }
                }
                else {
                    ViewBag.result = "login nie istnieje";
                }
            }
            else {
                ViewBag.model = false;
                ViewBag.result = "Brak danych";
            }

            return View(vm);
        }

        private string getStringFromSHA1(string input) {
            using var sha1 = SHA1.Create();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder(hash.Length * 2);

            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
