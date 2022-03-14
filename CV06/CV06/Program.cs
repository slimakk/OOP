using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Kruh(5);
            circle.Kresli();
            Console.WriteLine(circle.SpoctiPlochu());
            Console.ReadLine();
        }
    }
}
