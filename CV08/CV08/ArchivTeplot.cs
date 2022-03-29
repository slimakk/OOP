using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV08
{
    internal class ArchivTeplot
    {
        private SortedDictionary<int,RocniTeplota> _archiv;

        public ArchivTeplot()
        {
            this._archiv = new SortedDictionary<int, RocniTeplota>();
        }
        public void Load(String path)
        {
            var subor = File.ReadAllLines(path);
            foreach(var line in subor)
            {
                string[] temp = line.Split(':');
                int rok = int.Parse(temp[0]);
                List<string> teploty = temp[1].Split(';').ToList();
                List<double> temps = new List<double>();
                foreach (var teplota in teploty)
                {
                    temps.Add(double.Parse(teplota));
                }
                _archiv.Add(rok, new RocniTeplota(rok, temps));
            }

        }
        public void Save(String path)
        {
            StringBuilder line = new StringBuilder();
            foreach(var temp in _archiv.Values)
            {
                line.AppendFormat("{0}:", temp.Rok);
                for (int i = 0; i < temp.MesacneTeploty.Count(); i++)
                {
                    line.AppendFormat(" {0};", temp.MesacneTeploty[i]);
                }
                line.AppendLine("");
            }
            string result = line.ToString();
            File.WriteAllText(path,result);
        }
        public void Kalibracia(double offset)
        {
            foreach (var temp in _archiv.Values)
            {
                for(int i = 0; i < temp.MesacneTeploty.Count;i++)
                {
                    temp.MesacneTeploty[i] += offset;
                }
            }
        }
        public void Vyhladaj(int rok)
        {
            Console.WriteLine("Hladam: {0}", rok);
            if (_archiv.ContainsKey(rok))
            {
                Console.Write("{0}: ", rok);
                for (int i = 0; i < _archiv[rok].MesacneTeploty.Count; i++)
                {
                    Console.Write("{0}; ", _archiv[rok].MesacneTeploty[i]);
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("Nenasiel som");
        }
        public void TiskTeplot()
        {
            Console.WriteLine("Teploty: ");
            foreach(var value in _archiv.Values)
            {
                Console.Write("{0}: ", value.Rok);
                for(int i = 0; i < value.MesacneTeploty.Count; i++)
                {
                    Console.Write("{0}; ", value.MesacneTeploty[i]);
                }
                Console.WriteLine();
            }
        }
        public void TiskPriemernychRocnychTeplot()
        {
            Console.WriteLine("Priemerne rocne teploty");
            foreach(var value in _archiv.Values)
            {
                Console.WriteLine("{0}: {1:0.0}", value.Rok, value.PriemerTeplota);
            }
            //Console.WriteLine();
        }
        public void TiskPriemernychMesacnychTeplot()
        {
            double[] mesacnyPriemer = new double[12];
            foreach (var value in _archiv.Values)
            {
                for(int i = 0; i < value.MesacneTeploty.Count; i++)
                {
                    mesacnyPriemer[i] += value.MesacneTeploty[i];
                }
            }
            Console.Write("Priemer: ");
            for(int i = 0; i < mesacnyPriemer.Length; i++)
            {
                mesacnyPriemer[i] = mesacnyPriemer[i] / _archiv.Count;
                Console.Write("{0:0.0}; ", mesacnyPriemer[i]);
            }
        }
    }
}
