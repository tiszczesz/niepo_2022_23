using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ogloszenia2MVC.Models
{
    [Table("uzytkownik")]
    public class User
    {
        [Key]
        public int id { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public virtual List<Announcement> Ogloszenias { get; set; }
    }
}
