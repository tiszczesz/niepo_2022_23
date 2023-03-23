using Microsoft.AspNetCore.Mvc;
using WebEmptyMySql_v1.Models;

namespace WebEmptyMySql_v1.Controllers
{
    public class MainController : Controller {
        private string connString;

        public MainController(IConfiguration configuration) {
            this.connString = configuration.GetConnectionString("MyConn");
        }
        public IActionResult Index() {
            CarsRepo repo = new CarsRepo(connString);
            var cars = repo.GetCars();
            return View(cars);
        }
    }
}
