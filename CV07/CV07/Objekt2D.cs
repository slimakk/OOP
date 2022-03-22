using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    abstract class Objekt2D : I2D, IComparable
    {
        public abstract double Plocha();

        public int CompareTo(object obj)
        {
            if(obj is Objekt2D)
            {
                var first = Plocha();
                var second = ((Objekt2D)obj).Plocha();
                return first.CompareTo(second);
            }
            else
            {
                throw new Exception("Neporovnatelne");
            }
        }
    }
}
