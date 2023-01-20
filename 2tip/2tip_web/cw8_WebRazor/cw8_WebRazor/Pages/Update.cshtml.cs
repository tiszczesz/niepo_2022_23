using cw8_WebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw8_WebRazor.Pages
{
    public class UpdateModel : PageModel
    {
        [BindProperty] 
        public Contact ContactToUpdate { get; set; }

        private RepoContacts _repo = new RepoContacts();
        public IActionResult OnGet(int? id) {
            if(id==null) new RedirectToPageResult("MyPage");
            ContactToUpdate = _repo.GetById(id);
            if (ContactToUpdate!=null) {
                return Page();
            }
            else {
                return new RedirectToPageResult("MyPage");
            }
            
        }
    }
}
