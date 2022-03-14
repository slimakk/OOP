using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Obdelnik : Objekt2D
    {
        private double a;
        private double b;
        
        public Obdelnik(double a, double b)
        {
            this.a = a; this.b = b;
        }
        public double A { get { return a; } }
        public double B { get { return b; } }

        public override double SpoctiPlochu()
        {
            return A * B;
        }
        public override void Kresli()
        {
            Console.WriteLine("Obdlznik: (sirka = {0}; vyska = {1})", A, B);
        }
    }
}
