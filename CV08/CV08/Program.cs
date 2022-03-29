using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArchivTeplot teploty = new ArchivTeplot();
            teploty.Load(@"..\..\teploty.txt");
            teploty.TiskTeplot();
            teploty.Kalibracia(-0.1);
            teploty.TiskTeplot();
            teploty.Vyhladaj(2011);
            teploty.TiskPriemernychRocnychTeplot();
            teploty.TiskPriemernychMesacnychTeplot();
            teploty.Save(@"..\..\teploty1.txt");
            Console.ReadLine();
        }
    }
}
