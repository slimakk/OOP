using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Trojuhelnik : Objekt2D
    {
        private double a;
        private double v_a;
        public Trojuhelnik(double a, double v)
        {
            this.a = a; this.v_a = v;
        }
        public void Kresli()
        {
            Console.WriteLine("Trojuholnik (strana a = {0} vyska na stranu a = {1})", a, v_a);
        }

        public double SpoctiPlochu()
        {
            return (a * v_a) / 2;
        }
    }
}
