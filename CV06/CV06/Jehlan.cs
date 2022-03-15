using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Jehlan : Objekt3D
    {
        private double a;
        private double v;
        public Jehlan(double a, double v)
        {
            this.a = a; this.v = v; 
        }
        public void Kresli()
        {
            Console.WriteLine("Ihlan (sirka = {0} vyska = {1})", a, v);
        }

        public double SpoctiObjem()
        {
            return (1/3)*a*a*v;
        }

        public double SpoctiPovrch()
        {
            return a*(a+Math.Sqrt(4*v*v+a*a));
        }
    }
}
