using cw8_WebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw8_WebRazor.Pages
{
    public class ResultDeleteModel : PageModel {
        private RepoContacts repo;

        public ResultDeleteModel() {
            repo = new RepoContacts();
        }
        public IActionResult OnGet(int id, int isDelete = 0)
        {
            if (isDelete == 1) {
                Contact? contactToRemove = repo.Contacts.Find(c => c.Id == id);
                if (contactToRemove != null) {
                    repo.Contacts.Remove(contactToRemove);
                    repo.SaveToFile();
                }
               
            }

            return new RedirectToPageResult("MyPage");
        }
    }
}
