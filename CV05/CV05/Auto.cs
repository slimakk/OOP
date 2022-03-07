using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV05
{
    class Auto
    {
        protected int velikostNadrze;
        protected int stavNadrze;
        protected TypPaliva Palivo;
        public enum TypPaliva
        {
            Benzin,
            Nafta
        }
        public int VelikostNadrze
        {
            get { return velikostNadrze; }
            set { velikostNadrze = value; }
        }
        public TypPaliva palivo
        {
            get { return Palivo; }
            set { Palivo = value; }
        }
        public int StavNadrze
        {
            get { return stavNadrze; }
            set { stavNadrze = value; }
        }
        public Auto(int stavPaliva, TypPaliva palivo)
        {
            stavNadrze = stavPaliva;
            this.palivo = palivo;
        }
        public void Natankuj (TypPaliva palivo, int mnozstvo)
        {
            if(stavNadrze+mnozstvo <= VelikostNadrze && this.Palivo == palivo )
            {
                stavNadrze += mnozstvo;
            }
            else
            {
                throw new Exception("Zle palivo");
            }
        }
    }
}
