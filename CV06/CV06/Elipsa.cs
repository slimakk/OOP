using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Elipsa : Objekt2D
    {
        private double a;
        private double b;
        public Elipsa(double a, double b)
        {
            this.a = a; this.b = b;
        }
        public void Kresli()
        {
            Console.WriteLine("Elipsa (sirka = {0} vyska = {1}", a, b);
        }

        public double SpoctiPlochu()
        {
            return 3.14 * a * b;
        }
    }
}
