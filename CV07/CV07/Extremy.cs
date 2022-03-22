using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal class Extremy
    {
        public static T Najvacsia<T>(params T[] plochy) where T : IComparable
        {
            return plochy.Max();
        }
        public static T Najmensia<T>(params T[] plochy) where T : IComparable
        {
            return plochy.Min();
        }
    }
}
