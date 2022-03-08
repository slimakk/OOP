using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV05
{
    internal class Autoradio
    {
        private bool radioZapnute;
        private double naladenyKmitocet;
        private Dictionary<int, double> predvolbyRadio = new Dictionary<int, double>()
        {
            {1,100.2 },
            {2,108.3 },
            {3,105.7 },
            {4, 102.4 }
        };
        public Autoradio(bool zapnute, int predvolba)
        {
            RadioZapnute = zapnute;
            PreladNaPredvolbu(predvolba);
        }
        public bool RadioZapnute
        {
            get { return radioZapnute; }
            set { radioZapnute = value; }
        }
        public double NaladenyKmitocet
        {
            get { return naladenyKmitocet; }
            set { naladenyKmitocet = value; }
        }
        public void NastavPredvolbu(int predvolba, double kmitocet)
        {
            predvolbyRadio[predvolba] = kmitocet;
        }
        public void PreladNaPredvolbu (int predvolba)
        {
            if (!predvolbyRadio.ContainsKey(predvolba))
                throw new ArgumentException("Zadana predvolba neexistuje");
            NaladenyKmitocet = predvolbyRadio[predvolba];
        }
        public override string ToString()
        {
            return String.Format("Radio Zapnute:{0} Naladene: {1}", RadioZapnute, NaladenyKmitocet);
        }
    }
}
