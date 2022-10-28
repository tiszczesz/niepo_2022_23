using System.ComponentModel.DataAnnotations;

namespace OgloszeniaMVCMysql.Models
{
    public class Uzytkownicy
    {
        [Key]
        public int id { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        //public List<Ogloszenia> Ogloszenias { get; set; }
    }
}
