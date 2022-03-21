using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal class Kruh : Objekt2D
    {
        private double r;
        public Kruh (double r)
        {
            this.r = r;
        }
        public override double Plocha()
        {
            return r * r * Math.PI;
        }
        public override string ToString()
        {
            return String.Format("Plocha kruhu: {0:F2}",Plocha());
        }
    }
}
