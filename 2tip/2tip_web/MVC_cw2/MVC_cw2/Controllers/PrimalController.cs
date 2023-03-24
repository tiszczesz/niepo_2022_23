using Microsoft.AspNetCore.Mvc;
using MVC_cw2.Models;

namespace MVC_cw2.Controllers
{
    public class PrimalController : Controller
    {
        public PrimalGenerator PrimalGenerator { get; set; }

        [HttpGet]
        public IActionResult Index() {
            PrimalGenerator = new PrimalGenerator();
            return View(PrimalGenerator);
        }

        [HttpPost]
        public IActionResult Index(PrimalGenerator pg) {
            if (ModelState.IsValid) {
                ViewBag.primals = pg.GetPrimals((int)pg.Limit);
            }
            return View();
        }
    }
}
