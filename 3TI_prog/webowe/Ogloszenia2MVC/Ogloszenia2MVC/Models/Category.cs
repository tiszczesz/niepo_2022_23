using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ogloszenia2MVC.Models
{
    [Table("kategorie")]
    public class Category
    {
        [Key]
        public int id { get; set; }
        public string nazwa { get; set; }
        public string opis { get; set; }
    }
}
