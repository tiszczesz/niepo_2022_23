using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ogloszenia2MVC.Models
{
    [Table("ogloszenie")]
    public class Announcement
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey(nameof(User))]
        public int uzytkownik_id { get; set; }

        [ForeignKey(nameof(Category))]
        public int kategoria { get; set; }
        public int podkategoria { get; set; }
        public string tytul { get; set; }
        public string tresc { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
    }
}
