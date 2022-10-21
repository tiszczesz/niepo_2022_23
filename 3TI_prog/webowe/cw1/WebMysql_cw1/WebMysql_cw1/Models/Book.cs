using System.ComponentModel.DataAnnotations;

namespace WebMysql_cw1.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }

    }
}
