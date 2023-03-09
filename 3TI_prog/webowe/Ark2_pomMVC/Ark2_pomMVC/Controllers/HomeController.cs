
using Ark2_pomMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ark2_pomMVC.Controllers
{
    public class HomeController : Controller {
        private 
            _3tiProgBazaContext _db;

        public HomeController(_3tiProgBazaContext db)
        {
            _db = db;
        }
        public IActionResult Index() {
            var best = _db.Kliencis.OrderByDescending(k=>k.Punkty).Take(3).ToList();
            ViewBag.BestClients = best;
            var dane1 = _db.Kliencis.Include(k => k.Opinies)
                .Where(k=>(k.TypyId==2 || k.TypyId==3)).ToList();

            return View(dane1);
        }
    }
}
