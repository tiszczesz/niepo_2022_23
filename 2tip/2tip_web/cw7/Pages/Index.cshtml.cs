using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        public string FirstName { get; set; }
        public List<string> MyNames { get; set; }
        public void OnGet()
        {
            MyNames = new List<string>{"ala","bela","cela","inne","inniejsze"};
            FirstName = "Alojzy Bałecki";
        }
    }
}
