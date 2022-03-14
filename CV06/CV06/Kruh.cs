using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Kruh : Objekt2D
    {
        private double r;
        public Kruh(double r)
        {
            this.r = r;
        }
        public double R { get { return r; } }
        public override double SpoctiPlochu()
        {
            return 3.14 * R * R;
        }
        public override void Kresli ()
        {
            Console.WriteLine("Kruh (r = {0})", R);
        }
    }
}
