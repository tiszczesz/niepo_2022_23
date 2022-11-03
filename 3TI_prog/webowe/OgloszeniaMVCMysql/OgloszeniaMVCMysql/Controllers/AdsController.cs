using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OgloszeniaMVCMysql.Models;
using OgloszeniaMVCMysql.ViewModels;

namespace OgloszeniaMVCMysql.Controllers
{
    public class AdsController : Controller {
        private MyAppContext _db;

        public AdsController(MyAppContext db) {
            _db = db;
        }
        public IActionResult Index() {
            IndexViewModel indexViewModel = new IndexViewModel();
            indexViewModel.Kategories = _db.Kategories.ToList();
            indexViewModel.Uzytkownicies = _db.AllUzytkownicy.Where(k => k.id < 4).Include(u=>u.Ogloszenias).ToList();
            return View(indexViewModel);
        }
    }
}
