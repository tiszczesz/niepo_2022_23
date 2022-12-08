using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWD_WPF.Models
{
    public class NWD
    {
        public static int NWDRec(int a,int b) {
            if (b == 0) return a;
            return NWDRec(b, a % b);
        }

        public static int NWDIter(int a, int b) {
            int temp = a;
            while (b != 0) {
                temp = a;
                a = b;
                b = temp % a;
            }
            return a;
        }
    }
    public class Data {
        public int A { get; set; } = 12;
        public int B { get; set; } = 34;
        public List<string> Methods { get; set; } = new List<string>() { "Moteda rekurencyjna", "Metoda iteracyjna" };
    }
}
