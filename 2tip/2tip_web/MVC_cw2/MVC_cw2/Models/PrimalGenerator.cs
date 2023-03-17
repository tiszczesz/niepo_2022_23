using System.ComponentModel.DataAnnotations;

namespace MVC_cw2.Models
{
    public class PrimalGenerator
    {
        [Display(Name = "Górna granica")]
        [Required(ErrorMessage = "Musisz podać zakres")]
        [Range(2,3000000,ErrorMessage = "liczby z przedziału 2..3000000")]
        public int? Limit { get; set; }
        public List<int> Primals { get; set; }
        public bool IsPrimal(int number) {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++) {
                if (number % i == 0) return false;
            }
            return true;
        }

        public List<int> GetPrimals(int limit) {
            List<int> primals = new List<int>();
            for (int i = 2; i <= limit; i++) {
                if(IsPrimal(i)) primals.Add(i);
            }
            Primals = primals;
            return primals;
        }
    }
}
