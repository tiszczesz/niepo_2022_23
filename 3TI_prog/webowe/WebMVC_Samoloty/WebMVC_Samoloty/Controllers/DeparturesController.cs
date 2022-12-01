using Microsoft.AspNetCore.Mvc;

namespace WebMVC_Samoloty.Controllers
{
    public class DeparturesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
