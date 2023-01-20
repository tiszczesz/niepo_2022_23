using cw8_WebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw8_WebRazor.Pages
{
    public class DeleteModel : PageModel
    {
        public int Id { get; set; }
        public Contact Contact { get; set; }
        public RepoContacts MyRepo { get; set; }

        public DeleteModel() {
            MyRepo = new RepoContacts();
        }
        public void OnGet(int? id)
        {
            if (id != null) {
                Contact = MyRepo.GetById(id);
            }
        }
    }
}
