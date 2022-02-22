using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Zadaj prvu realnu zlozku");
            double realna1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadaj prvu imaginarnu zlozku");
            double imaginarna1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadaj druhu realnu zlozku");
            double realna2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadaj druhu imaginarnu zlozku");
            double imaginarna2 = Convert.ToDouble(Console.ReadLine());*/
            Complex x = new Complex(5.1, -5);
            Complex y = new Complex(7.8, 10);
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(-x);
            Console.WriteLine(-y);
            Console.ReadLine();
        }
    }
}
