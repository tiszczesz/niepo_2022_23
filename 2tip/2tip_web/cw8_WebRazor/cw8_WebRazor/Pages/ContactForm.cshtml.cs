using cw8_WebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw8_WebRazor.Pages
{
    
    public class ContactFormModel : PageModel
    {
        RepoContacts _contacts;

        public ContactFormModel() {
            _contacts = new RepoContacts();
        }
        public void OnGet()
        {
        }

        public void OnPost() {
            //_contacts.Contacts.Add(to co z formularza)
            //_contacts.SaveToFile();
        }
    }
}
