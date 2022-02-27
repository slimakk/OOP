using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
                + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                + "posledni veta!";
            StringStatistics test = new StringStatistics(testovaciText);
            Console.WriteLine("Pocet slov {0} ", test.WordCounter());
            Console.WriteLine("Pocet riadkov {0}", test.LineCounter());
            Console.WriteLine(test.SentenceCounter());
            Console.ReadLine();
        }
    }
}
