using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_Mysql_cw1.Models;

namespace WebApp_Mysql_cw1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UsersRepo _db;

        public HomeController(ILogger<HomeController> logger
                ,IConfiguration configuration)
        {
            _logger = logger;
            var connString = configuration.GetConnectionString("MySqlConn");
            _db = new UsersRepo(connString);
        }

        public IActionResult Index() {
            var list = _db.GetAll();
            return View(list);
        }

        [HttpGet]
        public IActionResult AddUser() {

            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user) {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}