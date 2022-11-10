using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgloszeniaMVCMysql.Models
{
    public class Ogloszenia
    {
        [Key]
        public int Id { get; set; }

        
        [ForeignKey(nameof(Uzytkownicy))]
        public int uzytkownik_id { get; set; }

        [ForeignKey(nameof(Kategorie))]
        public int kategoria { get; set; }
        public int podkategoria { get; set; }
        public string tytul { get; set; }
        public string tresc { get; set; }
        public Uzytkownicy Uzytkownicy { get; set; }
        public Kategorie Kategorie { get; set; }
    }
}
