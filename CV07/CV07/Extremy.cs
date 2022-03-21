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
            T max = plochy[0];
            for(int i = 1; i < plochy.Length; i++)
            {
                if(plochy[i].CompareTo(max) > 0)
                {
                    max = plochy[i];
                }
            }
            return max;
        }
        public static T Najmensia<T>(params T[] plochy) where T : IComparable
        {
            T min = plochy[0];
            for(int i = 1; i < plochy.Length; i++)
            {
                if(plochy[i].CompareTo(min) < 0)
                {
                    min = plochy[i];
                }
            }
            return min;
        }
    }
}
