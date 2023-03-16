namespace MVC_cw2.Models
{
    public class PrimalGenerator
    {
        public bool IsPrimal(int number) {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++) {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
