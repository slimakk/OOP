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
        public Osobni(TypPaliva AktPalivo, int stavNadrze, int prepravovane = 0) : base(stavNadrze, AktPalivo)
        {
            maxOsob = 5;
            VelikostNadrze = 50;
            if (prepravovane <= maxOsob)
            {
                prepravovaneOsoby = prepravovane;
            }
            else
            {
                throw new Exception("Pocet prepravovanych osob presahuje maximalny pocet osob");
            }
            if( stavNadrze <= VelikostNadrze)
            {
                palivo = AktPalivo;
            }
            else
            {
                throw new Exception("Zadane mnozstvo paliva prevysuje objem nadrze");
            }
        }

        public override string ToString()
        {
            return String.Format("Pocet osob:{0} Natankovane palivo: {1} {2} L", prepravovaneOsoby,palivo, StavNadrze);
        }
    }
}
