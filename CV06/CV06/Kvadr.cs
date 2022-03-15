using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Kvadr : Objekt3D
    {
        private double a;
        private double b;
        private double c;
        public Kvadr(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public void Kresli()
        {
            Console.WriteLine("Kvader (sirka = {0} vyska = {1} hlbka = {2})",a,b,c);
        }

        public double SpoctiObjem()
        {
            return a * b * c;
        }

        public double SpoctiPovrch()
        {
            return 2*(a*b+a*c+b*c);
        }
    }
}
