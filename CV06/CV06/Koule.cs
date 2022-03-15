using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Koule : Objekt3D
    {
        private double r;
        public Koule(double r)
        {
            this.r = r;
        }
        public void Kresli()
        {
            Console.WriteLine("Gula (r = {0})", r);
        }

        public double SpoctiObjem()
        {
            return (4 / 3) * 3.14 * r * r * r;
        }

        public double SpoctiPovrch()
        {
            return 4 * 3.14 * r * r;
        }
    }
}
