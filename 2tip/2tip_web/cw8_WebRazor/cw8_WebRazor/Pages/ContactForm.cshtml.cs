using cw8_WebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw8_WebRazor.Pages
{
    
    public class ContactFormModel : PageModel
    {
        RepoContacts _contacts;

        [BindProperty]
        public Contact MyContact { get; set; }
        public ContactFormModel() {
            _contacts = new RepoContacts();
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost() {
            if (ModelState.IsValid) {
                 MyContact.Id = _contacts.GetNewId();
                 _contacts.Contacts.Add(MyContact);
                 _contacts.SaveToFile();
                 return new RedirectToPageResult("MyPage");
            }
            else {
                return Page();
            }
           
            
        }
    }
}
