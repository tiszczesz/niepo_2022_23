using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw8_WebRazor.Pages
{
    public class MyFormModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost() {

            string firstname = Request.Form["firstname"];
            string lastname = Request.Form["lastname"];
            string dateBirth = Request.Form["dateBirth"];
            ViewData["post"] = true;
            ViewData["firstname"] = firstname;
            ViewData["lastname"] = lastname;
            ViewData["dateBirth"] = dateBirth;
        }
    }
}
