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
            var list = new List<GrObjekt>();
            double celkPlocha = 0;
            double celkPovrch = 0;
            double celkObjem = 0;
            list.Add(new Kruh(5));
            list.Add(new Obdelnik(3,5));
            list.Add(new Elipsa(3, 6));
            list.Add(new Trojuhelnik(3,5));
            list.Add(new Kvadr(3,4,5));
            list.Add(new Valec(2, 7));
            list.Add(new Koule(5));
            list.Add(new Jehlan(3, 7));
            foreach (GrObjekt grObjekt in list)
            {
                grObjekt.Kresli();
                if(grObjekt is Objekt2D )
                {
                    var objekt = (Objekt2D)grObjekt;
                    celkPlocha += objekt.SpoctiPlochu(); 
                }
                if(grObjekt is Objekt3D )
                {
                    var objekt = (Objekt3D)grObjekt;
                    celkPovrch += objekt.SpoctiPovrch();
                    celkObjem += objekt.SpoctiObjem();
                }
            }
            Console.WriteLine("Celkova plocha: {0} \nCelkovy povrch: {1, 0:F2} \nCelkovy objem: {2}",celkPlocha,celkPovrch,celkObjem);
            Console.ReadLine(); 
        }
    }
}
