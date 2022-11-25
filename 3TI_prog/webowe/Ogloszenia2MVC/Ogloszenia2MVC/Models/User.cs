using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ogloszenia2MVC.Models
{
    [Table("uzytkownik")]
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Podaj imię")]
        public string imie { get; set; }
        [Required(ErrorMessage = "Podaj nazwisko")]
        public string nazwisko { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        
        public virtual List<Announcement>? Ogloszenias { get; set; }
    }
}
