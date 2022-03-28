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
            teploty.Load(@"teploty.txt");
            teploty.TiskTeplot();
            
            Console.ReadLine();
        }
    }
}
