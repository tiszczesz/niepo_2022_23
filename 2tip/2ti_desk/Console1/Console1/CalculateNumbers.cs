using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    public class CalculateNumbers
    {
        public double FirstNumber { get; set; } = 0;
        public double SecondNumber { get; set; } = 0;

        public double Add()
        {
            return FirstNumber + SecondNumber;
        }
        public double Subtract()
        {
            return FirstNumber-SecondNumber;
        }
        public double Divie()
        {
            if (SecondNumber == 0) throw new DivideByZeroException("Dzielimy przez zero");
            return FirstNumber/SecondNumber;
        }

    }
}
