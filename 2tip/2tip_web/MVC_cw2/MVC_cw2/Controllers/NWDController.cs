using Microsoft.AspNetCore.Mvc;
using MVC_cw2.Models;

namespace MVC_cw2.Controllers
{
    public class NWDController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(NWDCounter nwd)
        {
            if (ModelState.IsValid) {

            }
            return View();
        }
    }
}
