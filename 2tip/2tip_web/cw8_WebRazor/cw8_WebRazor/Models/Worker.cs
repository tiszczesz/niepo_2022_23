using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace cw8_WebRazor.Models {
    public class Worker {
        [Required(ErrorMessage = "Podaj imię")]
        [DisplayName("Podaj imię")]
        [MinLength(3, ErrorMessage = "Muszą być 3 litery")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Podaj nazwisko")]
        [DisplayName("Podaj nazwisko")]
        [MinLength(3, ErrorMessage = "Muszą być 3 litery")]
        public string? LastName { get; set; }

        [DisplayName("Miejsce pracy")] public string Workplace { get; set; }

        [DisplayName("Pensja")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        //[DisplayName("Płeć")]
        //public string Gender { get; set; } = "Kobieta";

        //[DisplayName("Zainteresowania")]
        //public List<HobbyItem> Hobbies { get; set; }
    }
}
