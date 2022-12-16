using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw8_WebRazor.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [DisplayName("Nazwa kontaktu: ")]
        [Required(ErrorMessage = "Proszę podać nazwę kontaktu")]
        [MinLength(2,ErrorMessage = "Co najmniej 2 znaki")]
        public string Name { get; set; }

        [DisplayName("Telefon: ")]
        [Required(ErrorMessage = "Proszę podać telefon")]
        public string Phone { get; set; }

        [DisplayName("Adres email: ")]
        [Required(ErrorMessage = "Proszę podać telefon")]
        public string Email { get; set; }

        public string SerializeContact() {
            return $"{Id}|{Name}|{Phone}|{Email}";
        }
    }
}
