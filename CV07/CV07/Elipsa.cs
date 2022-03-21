using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal class Elipsa : Objekt2D
    {
        private double a;
        private double b;
        public Elipsa(double a, double b)
        {
            this.a = a; this.b = b;
        }

        public override double Plocha()
        {
            return a * b * Math.PI;
        }
        public override string ToString()
        {
            return String.Format("Plocha elipsy: {0:F2}",Plocha());
        }
    }
}
