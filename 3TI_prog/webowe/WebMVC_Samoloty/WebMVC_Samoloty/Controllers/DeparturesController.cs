using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMVC_Samoloty.Data;

namespace WebMVC_Samoloty.Controllers
{
    public class DeparturesController : Controller {
        private Ark3odlotyContextDb _db;

        public DeparturesController(Ark3odlotyContextDb db) {
            _db = db;
        }
        public IActionResult Index() {
            Response.Cookies.Append("odwiedzone","true",
                new Microsoft.AspNetCore.Http.CookieOptions() {
                    Path = "/",
                    Expires = DateTimeOffset.Now.AddHours(1)
                });
            var cookies = Response.Cookies;
            if (cookies != null && Request.Cookies["odwiedzone"] != null) {
                ViewBag.cookie = Request.Cookies["odwiedzone"].ToString();
            } 
            var odloty = _db.Odloties.Include(o=>o.Samoloty)
                .OrderByDescending(o=>o.Czas).ToList();
            return View(odloty);
        }

        public IActionResult Details(uint id) {
            var info = _db.Samoloties.Find(id);
            if (info == null) return RedirectToAction("Index");

            return View(info);
        }
    }
}
