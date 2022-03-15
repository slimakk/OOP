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
        public Kruh(int r)
        {
            this.r = r;
        }
        public void Kresli()
        {
            Console.WriteLine("Kruh (r = {0})",r);
        }

        public double SpoctiPlochu()
        {
            return 3.14 * r * r;
        }
    }
}
