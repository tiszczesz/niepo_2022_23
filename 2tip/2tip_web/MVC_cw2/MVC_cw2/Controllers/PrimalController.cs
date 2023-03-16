using Microsoft.AspNetCore.Mvc;

namespace MVC_cw2.Controllers
{
    public class PrimalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
