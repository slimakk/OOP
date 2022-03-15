using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Valec : Objekt3D
    {
        private double r;
        private double v;
        public Valec(double r, double v)
        {
            this.r = r; this.v = v;
        }
        public void Kresli()
        {
            Console.WriteLine("Valec (r = {0} v = {1})",r,v);
        }

        public double SpoctiObjem()
        {
            return 3.14 * r * r * v;
        }

        public double SpoctiPovrch()
        {
            return 2 * 3.14 * r * (r + v);
        }
    }
}
