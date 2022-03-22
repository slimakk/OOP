using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = new int[] { 1, 3, 5, 7, 9};
            string[] cisla2 = new string[] { "jeden", "dva", "trinast", "osem" };
            Kruh[] kruhy = new Kruh[] { new Kruh(5), new Kruh(2), new Kruh(8) };
            Obdelnik[] obdl =new Obdelnik[] { new Obdelnik(2, 3), new Obdelnik(7, 6), new Obdelnik(2, 9) };
            Elipsa[] elps =new Elipsa[] { new Elipsa(3, 5), new Elipsa(7, 2), new Elipsa(4, 8) };
            Trojuhelnik[] troj =new Trojuhelnik[] { new Trojuhelnik(2, 3), new Trojuhelnik(7,2),new Trojuhelnik(2, 9) };
            Stvorec[] stvr = new Stvorec[] { new Stvorec(5), new Stvorec(6), new Stvorec(7)};
            Objekt2D[] tvary = new Objekt2D[] { new Kruh(2), new Stvorec(7), new Trojuhelnik(2, 8) };
            Console.WriteLine("Najvacsie: {0}", Extremy.Najvacsia(cisla));
            Console.WriteLine("Najmensie: {0}", Extremy.Najmensia(cisla));

            Console.WriteLine("Posledne v abecede: {0}", Extremy.Najvacsia(cisla2));
            Console.WriteLine("Prve v abecede: {0}", Extremy.Najmensia(cisla2));

            Console.WriteLine("Najvacsia: {0}", Extremy.Najvacsia(kruhy));
            Console.WriteLine("Najmensia: {0}", Extremy.Najmensia(kruhy));

            Console.WriteLine("Najvacsia: {0}", Extremy.Najvacsia(obdl));
            Console.WriteLine("Najmensia: {0}", Extremy.Najmensia(obdl));

            Console.WriteLine("Najvacsia: {0}", Extremy.Najvacsia(elps));
            Console.WriteLine("Najmensia: {0}", Extremy.Najmensia(elps));

            Console.WriteLine("Najvacsia: {0}", Extremy.Najvacsia(troj));
            Console.WriteLine("Najmensia: {0}", Extremy.Najmensia(troj));

            Console.WriteLine("Najvacsia: {0}", Extremy.Najvacsia(stvr));
            Console.WriteLine("Najmensia: {0}", Extremy.Najmensia(stvr));

            Console.WriteLine("Najvacsia: {0}", Extremy.Najvacsia(tvary));
            Console.WriteLine("Najmensia: {0}", Extremy.Najmensia(tvary));
            

            var wanted =
                from cislo in cisla
                where (cislo >= 4 && cislo <= 8)
                select cislo;
            foreach (int cislo in wanted)
            {
                Console.WriteLine(cislo);
            }
            Console.ReadLine();
        }
    }
}
