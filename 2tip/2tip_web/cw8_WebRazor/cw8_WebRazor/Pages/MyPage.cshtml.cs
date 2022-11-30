using cw8_WebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw8_WebRazor.Pages
{
    public class MyPageModel : PageModel
    {
        public RepoContacts RepoContacts { get; set; }
        public List<Contact> Contacts { get; set; }

        public MyPageModel() {
            RepoContacts = new RepoContacts();
        }
        public void OnGet() {
            Contacts = RepoContacts.Contacts;
        }
    }
}
