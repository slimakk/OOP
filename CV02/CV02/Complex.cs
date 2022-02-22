using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV02
{
    public class Complex
    {
        public double Realna;
        public double Imaginarna;

        public Complex(double realna = 0.0, double imaginarna = 0.0)
        {
            Realna = realna;
            Imaginarna = imaginarna;
        }
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Realna+b.Realna, a.Imaginarna+b.Imaginarna);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Realna-b.Realna, a.Imaginarna-b.Imaginarna);
        }
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex((a.Realna * b.Realna) - (a.Imaginarna * b.Imaginarna), (a.Realna * b.Imaginarna) + (a.Imaginarna * b.Realna));
        }
        public static Complex operator /(Complex a, Complex b)
        {
            double menovatel = (b.Realna*b.Realna) + (b.Imaginarna*b.Imaginarna);
            double realna = (a.Realna * b.Realna) + (a.Imaginarna * b.Imaginarna);
            double imaginar = (a.Imaginarna*b.Realna)-(a.Realna*b.Imaginarna);
            return new Complex(realna / menovatel, imaginar / menovatel);
        }
        /*public static Complex operator ==(Complex a, Complex b)
        {
            return a.Realna == b.Realna;
        }
        public static Complex operator !=(Complex a, Complex b)
        {
            return a != b;
        }*/
        public static Complex operator -(Complex a)
        {
            return new Complex(-a.Realna, -a.Imaginarna);
        }
        public static Complex zdruzene(Complex a)
        {
            return new Complex(a.Realna, -a.Imaginarna);
        }
        public static Complex modul(Complex a)
        {
            return new Complex
        }
        public override string ToString()
        {
            if(Imaginarna < 0)
            {
                return String.Format("{0}-{1}j", Realna, -Imaginarna);
            }
            else
            {
                return String.Format("{0}+{1}j", Realna, Imaginarna);
            }
        }
    }
}
