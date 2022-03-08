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
            
            Osobni auto = new Osobni(Auto.TypPaliva.Benzin, 20.1, 50, 5, 4);
            Nakladni kamion = new Nakladni(Auto.TypPaliva.Nafta, 10, 200, 5000, 100);
            Console.WriteLine(auto);
            try 
            {
                auto.Natankuj(Auto.TypPaliva.Benzin, 10);
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message); 
            }
            auto.ZapniRadio();
            auto.Prelad(3);
            Console.WriteLine(auto);
            Console.WriteLine(kamion);
            try
            {
                kamion.Natankuj(Auto.TypPaliva.Benzin, 10);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            kamion.ZapniRadio();
            kamion.NastavRadio(5, 99.9);
            try
            {
                kamion.Prelad(5);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(kamion);
            Console.ReadLine();
        }
    }
}
