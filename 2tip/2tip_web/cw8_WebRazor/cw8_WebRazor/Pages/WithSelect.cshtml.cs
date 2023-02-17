using cw8_WebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace cw8_WebRazor.Pages
{
    public class WithSelectModel : PageModel
    {
        [BindProperty]
        public Worker MyWorker { get; set; }
        public List<string> WorkerPlaces { get; set; }
        public List<SelectListItem> WorkerPlace2 { get; set; }
        public List<string> Genders { get; set; }

        public WithSelectModel() {
            WorkerPlaces = new List<string>
            {
                "Asystent/ka","handlowiec","kierowca","sprzštacz/ka","kierownik"
            };
            WorkerPlace2 = new List<SelectListItem> {
                new SelectListItem{
                    Text="Asystent/ka",Value="Asystent/ka"},
                new SelectListItem{
                    Text="handlowiec",Value="handlowiec"},
                new SelectListItem{
                    Text="kierowca",Value="kierowca"},
                new SelectListItem{
                    Text="kierownik",Value="kierownik"}
            };
            Genders = new List<string> { "Kobieta", "Mê¿czyzna", "Inna" };
            if (MyWorker == null)
            {
                MyWorker = new Worker();
            }
            //MyWorker.Hobbies = new List<HobbyItem>
            //{
            //    new HobbyItem{Name = "Ksiš¿ki"},
            //    new HobbyItem{Name = "Filmy"},
            //    new HobbyItem{Name = "Sport"},
            //    new HobbyItem{Name = "Muzyka"},
            //    new HobbyItem{Name = "Teatr"},
            //    new HobbyItem{Name = "Taniec"}
            //};
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            ViewData["post"] = true;
            if (ModelState.IsValid)
            {
                var result = MyWorker;
            }
            else
            {

            }
        }
    }
}
