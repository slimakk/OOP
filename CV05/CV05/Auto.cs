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
        protected double stavNadrze;
        protected TypPaliva Palivo;
        private Autoradio radio = new Autoradio(false, 1);
        public enum TypPaliva
        {
            Benzin,
            Nafta
        }
        public int VelikostNadrze
        {
            get { return velikostNadrze; }
            protected set { velikostNadrze = value; }
        }
        public TypPaliva palivo
        {
            get { return Palivo; }
            protected set { Palivo = value; }
        }
        public double StavNadrze
        {
            get { return stavNadrze; }
            set {
                if (value > VelikostNadrze)
                    throw new ArgumentException("Nadrz preteka");
                stavNadrze = value; }
        }
        public Auto(double stavPaliva, TypPaliva palivo, int velkostNadrze)
        {
            VelikostNadrze=velkostNadrze;
            StavNadrze = stavPaliva;
            this.palivo = palivo;
        }
        public void Natankuj (TypPaliva palivo, int mnozstvo)
        {
            if(StavNadrze+mnozstvo <= VelikostNadrze && Palivo == palivo )
            {
                StavNadrze += mnozstvo;
            }
            else
            {
                throw new Exception("Zle palivo");
            }
        }
        public void ZapniRadio()
        {
            radio.RadioZapnute=true;
        }
        public void VypniRadio()
        {
            radio.RadioZapnute = false;
        }
        public void Prelad(int predvolba)
        {
            radio.PreladNaPredvolbu(predvolba);
        }
        public void NastavRadio(int predvolba, double kmitocet)
        {
            radio.NastavPredvolbu(predvolba, kmitocet);
        }
        public string StavRadia()
        {
            return radio.ToString();
        }
    }
}
