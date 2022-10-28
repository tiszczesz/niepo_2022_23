using System.ComponentModel.DataAnnotations;

namespace OgloszeniaMVCMysql.Models
{
    public class Kategorie
    {
        [Key]
        public int id { get; set; }
        public string nazwa { get; set; }
        public string opis { get; set; }
        //virtual public List<Ogloszenia> Ogloszenias { get; set; }
    }
}
