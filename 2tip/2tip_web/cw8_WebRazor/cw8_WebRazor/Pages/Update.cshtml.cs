using cw8_WebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw8_WebRazor.Pages
{
    public class UpdateModel : PageModel
    {
        [BindProperty] 
        public Contact ContactUpdated { get; set; }

        private RepoContacts _repo = new RepoContacts();
        public IActionResult OnGet(int? id) {
            if(id==null) new RedirectToPageResult("MyPage");
            ContactUpdated = _repo.GetById(id);
            if (ContactUpdated != null) {
                return Page();
            }
            else {
                return new RedirectToPageResult("MyPage");
            }
            
        }

        public IActionResult OnPost(int? id) {
            if (ModelState.IsValid) {
                Contact? contact = _repo.GetById(id);
                if (contact != null) {
                    contact.Email = ContactUpdated.Email;
                    contact.Name = ContactUpdated.Name;
                    contact.Phone = ContactUpdated.Phone;
                    _repo.SaveToFile();
                }
                return new RedirectToPageResult("MyPage");
            }
            return Page();
        }
    }
}
