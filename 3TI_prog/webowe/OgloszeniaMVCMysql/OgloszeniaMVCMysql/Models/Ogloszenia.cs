using System.ComponentModel.DataAnnotations;

namespace OgloszeniaMVCMysql.Models
{
    public class Ogloszenia
    {
        [Key]
        public int Id { get; set; }
        public int uzytkownik_id { get; set; }
        public int kategoria { get; set; }
        public int podkategoria { get; set; }
        public string tytul { get; set; }
        public string tresc { get; set; }
    }
}
