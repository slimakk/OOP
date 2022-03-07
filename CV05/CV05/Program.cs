using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osobni auto = new Osobni(Auto.TypPaliva.Benzin, 20, 3);
            Console.WriteLine(auto);
            Console.ReadLine();
        }
    }
}
