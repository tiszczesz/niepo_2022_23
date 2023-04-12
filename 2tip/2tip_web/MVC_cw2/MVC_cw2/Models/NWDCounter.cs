using System.ComponentModel.DataAnnotations;


namespace MVC_cw2.Models
{
    public class NWDCounter
    {
        [Display(Name = "Podaj A")]
        [Required(ErrorMessage = "Podaj A")]
        [Range(minimum:0,
            maximum:Int32.MaxValue,
            ErrorMessage = "Podaj Liczbę dodatnią")]
        public int? A { get; set; }

        [Display(Name = "Podaj B")]
        [Required(ErrorMessage = "Podaj B")]
        [Range(minimum: 0,
            maximum: Int32.MaxValue,
            ErrorMessage = "Podaj Liczbę dodatnią")]
        public int? B { get; set; }
        public int? Result { get; set; } = 0;

        public int GetNWD(int? a, int? b) {
            if (a != null && b != null) {
                int temp = 0;
                while (b!=0) {
                    temp = (int) a;
                    a = b;
                    b = temp%b;
                }

                return (int)a;
            }
            
            return 0;
        }
    }
}
