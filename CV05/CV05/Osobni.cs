using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV05
{
    class Osobni : Auto
    {
        private int maxOsob;
        private int prepravovaneOsoby;
        public Osobni(TypPaliva AktPalivo, double stavNadrze, int velkostNadrze, int maxOsoby = 1,int prepravovane = 0) : base(stavNadrze, AktPalivo, velkostNadrze)
        {
            MaxOsob = maxOsoby;
            PrepravovaneOsoby = prepravovane;
        }
        public int MaxOsob
        { 
            get { return maxOsob; } 
            private set { maxOsob = value; } 
        }
        public int PrepravovaneOsoby
        {
            get { return prepravovaneOsoby; }
            protected set {
                if (value > MaxOsob)
                    throw new ArgumentException("Naozaj chces jazdit ako Weiss?");
                prepravovaneOsoby = value; }
        }

        public override string ToString()
        {
            return String.Format("{0}\nPocet osob:{1} Natankovane palivo: {2} {3} L \n{4}", "Auto",PrepravovaneOsoby,Palivo, StavNadrze,StavRadia());
        }
    }
}
