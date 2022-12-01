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
            var odloty = _db.Odloties.Include(o=>o.Samoloty).OrderByDescending(o=>o.Czas).ToList();
            return View(odloty);
        }
    }
}
