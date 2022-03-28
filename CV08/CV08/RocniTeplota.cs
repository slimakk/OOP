using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV08
{
    internal class RocniTeplota
    {
        private int rok;
        private List<double> mesacneTeploty;
        private double maxTeplota;
        private double minTeplota;
        private double priemerRocnaTeplota;

        public RocniTeplota(int rok, List<double> mesacne)
        {
            this.rok = rok;
            this.mesacneTeploty = new List<double>();
            this.mesacneTeploty = mesacne;
        }
        public int Rok
        {
            get { return rok; }
            set { rok = value; }
        }
        public List<double> MesacneTeploty
        {
            get => mesacneTeploty;
            set => mesacneTeploty = value;
        }
        public double MaxTeplota
        {
            get
            { return mesacneTeploty.Max(); }
        }
        public double MinTeplota
        {
            get { return mesacneTeploty.Min(); }
        }
        public double PriemerTeplota
        {
            get { return mesacneTeploty.Average(); }
        }

    }
}
