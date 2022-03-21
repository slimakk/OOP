using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal class Stvorec : Objekt2D
    {
        private double a;
        public Stvorec(double a)
        {
            this.a = a;
        }
        public override double Plocha()
        {
            return a * a;
        }
        public override string ToString()
        {
            return "Plocha stvorca: "+Plocha();
        }
    }
}
