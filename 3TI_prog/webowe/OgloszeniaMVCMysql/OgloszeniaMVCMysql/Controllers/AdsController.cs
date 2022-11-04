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
        public IActionResult Index(int id) {
            IndexViewModel indexViewModel = new IndexViewModel();
            indexViewModel.Kategories = _db.Kategories.ToList();
            indexViewModel.OgloszeniaByCat = id == -1 ? _db.AllOgloszenia.ToList()
                : _db.AllOgloszenia.Where(o => o.uzytkownik_id == id).ToList();
            indexViewModel.Uzytkownicies = _db.AllUzytkownicy.Where(k => k.id < 4).Include(u=>u.Ogloszenias).ToList();
            return View(indexViewModel);
        }
    }
}
