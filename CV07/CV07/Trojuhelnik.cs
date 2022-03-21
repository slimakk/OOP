using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal class Trojuhelnik : Objekt2D
    {
        private double a;
        private double v_a;
        public Trojuhelnik(double a, double v_a)
        {
            this.a = a; this.v_a = v_a;
        }

        public override double Plocha()
        {
            return (a * v_a) / 2;
        }
        public override string ToString()
        {
            return String.Format("Plocha trojuholnika: {0:F2}",Plocha());
        }
    }
}
