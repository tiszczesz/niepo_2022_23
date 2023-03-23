using Microsoft.AspNetCore.Mvc;

namespace WebEmptyMySql_v1.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
