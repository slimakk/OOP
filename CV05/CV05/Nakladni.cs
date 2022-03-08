using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV05
{
    internal class Nakladni : Auto
    {
        private int maxNaklad;
        private int prepravovanyNaklad;
        public Nakladni(TypPaliva aktPalivo, double stavNadrze, int velkostNadrze, int maxNaklad, int prepravovanyNaklad = 0 ): base(stavNadrze, aktPalivo, velkostNadrze)
        {
            MaxNaklad=maxNaklad;
            PrepravovanyNaklad = prepravovanyNaklad;
        }
        public int MaxNaklad
        { 
            get { return maxNaklad; } 
            private set { maxNaklad = value; } 
        }
        public int PrepravovanyNaklad 
        { 
            get { return prepravovanyNaklad; } 
            protected set {
                if (value > MaxNaklad)
                    throw new ArgumentException("Pretazeny nakladiak");
                prepravovanyNaklad = value; } 
        }
        public override string ToString()
        {
            return String.Format("{0} \nNalozeny naklad: {1} kg, Palivo: {2}  {3}L \n{4}", "Nakladne",PrepravovanyNaklad, Palivo, StavNadrze,StavRadia());
        }
    }
}
