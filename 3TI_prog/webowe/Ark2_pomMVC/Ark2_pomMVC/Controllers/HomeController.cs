
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
            var dane1 = _db.Kliencis.Include(k => k.Opinies).Include(o=>o.Typy).Where(k=>(k.Typy.Id==2 && k.Typy.Id==3)).ToList();

            return View();
        }
    }
}
