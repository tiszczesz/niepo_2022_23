using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Cw2
{
    public class NumberGenerator {
        private int limit = 10;
        private List<int> numbers = new List<int>();
        public int Limit { get { return limit; } set { limit = value>0 ? value:-value; } }

        public NumberGenerator(int limit) {
            this.Limit = limit;
            generNumbers();
        }

        private void generNumbers() {
            Random rnd = new Random();
            for (int i = 0; i < Limit; i++) {
                numbers.Add(rnd.Next(200));
            }
        }
        public List<int> GetNumbers() {
            return numbers;
        }
    }
}
