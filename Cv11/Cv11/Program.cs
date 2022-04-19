using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv11
{
    class Program
    {
        public static void FillDB (DataClasses1DataContext dc)
        {
            if(!dc.Students.Any(s => s.Id == 2000))
            {
                dc.Students.InsertOnSubmit(new Student() { Id = 2000, DatumNarozeni = new DateTime(2000, 5, 13), Jmeno = "Franto", Prijmeni = "Vrbovsky"});
            }
            if(!dc.Students.Any(s => s.Id == 2001))
            {
                dc.Students.InsertOnSubmit(new Student() { Id = 2001, DatumNarozeni = new DateTime(1999, 4, 26), Jmeno = "Stefan", Prijmeni = "Lakatos" });
            }
            if(!dc.Predmets.Any(p => p.Zkratka == "BMA3"))
            {
                dc.Predmets.InsertOnSubmit(new Predmet() { Zkratka = "BMA3", Nazev = "Matematika 3" });
            }
            if(!dc.StudentPredmets.Any(p => p.ZkratkaPredmet == "BMA3") && !dc.StudentPredmets.Any(s => s.IdStudent == 2000))
            {
                dc.StudentPredmets.InsertOnSubmit(new StudentPredmet() { IdStudent = 2000, ZkratkaPredmet = "BMA3" });
            }
            if (!dc.StudentPredmets.Any(p => p.ZkratkaPredmet == "BMA3") && !dc.StudentPredmets.Any(s => s.IdStudent == 1005))
            {
                dc.StudentPredmets.InsertOnSubmit(new StudentPredmet() { IdStudent = 1005, ZkratkaPredmet = "BMA3" });
            }
            if(!dc.Hodnocenis.Any(h => h.IdStudent == 2000) && !dc.Hodnocenis.Any(h => h.ZkratkaPredmet == "BMA3"))
            {
                dc.Hodnocenis.InsertOnSubmit(new Hodnoceni() { IdStudent = 2000, ZkratkaPredmet = "BMA3", Datum = new DateTime(2022, 1, 6), Znamka = 1.5 });
            }
            dc.SubmitChanges();
        }
        public static void VypisStudentov(DataClasses1DataContext dc)
        {
            var pocet = dc.VypisStudentovs.OrderByDescending(x => x.Pocet);
            foreach (var val in pocet)
            {
                Console.WriteLine(val.ZkratkaPredmet + ":" + val.Pocet);
            }
        }
        public static IEnumerable<Student> StudentiPredmetu (DataClasses1DataContext dc, string zkr)
        {
            IEnumerable<Student> students;
            students = from p in dc.StudentPredmets
                       join s in dc.Students on p.IdStudent
                       equals s.Id
                       where p.IdStudent == s.Id
                       && p.ZkratkaPredmet == zkr
                       select s;
            return students;
        }
        public static IEnumerable<Predmet> PredmetyStudenta(DataClasses1DataContext dc, int id)
        {
            IEnumerable<Predmet> predmety;
            predmety = from p in dc.StudentPredmets
                       join s in dc.Predmets on p.ZkratkaPredmet
                       equals s.Zkratka
                       where p.ZkratkaPredmet == s.Zkratka
                       && p.IdStudent == id
                       select s;
            return predmety;
        }
        public static void AvgZnamka(DataClasses1DataContext dc)
        {
            var predmety = dc.Hodnocenis
                .GroupBy(g => g.ZkratkaPredmet, p => p.Znamka)
                .Select(g => new { ZkratkaPredmet = g.Key, Znamka = g.Average() });
            foreach(var predmet in predmety)
            {
                Console.WriteLine("Skratka: {0}, Priemerna znamka: {1}", predmet.ZkratkaPredmet, predmet.Znamka);
            }
        }
        static void Main(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            FillDB(dc);
            VypisStudentov(dc);
            Console.WriteLine("Studenti predmetu BOOP");
            IEnumerable<Student> students = StudentiPredmetu(dc, "BOOP");
            foreach(var value in students)
            {
                Console.WriteLine("ID: {0}, Meno: {1}, Priezvisko: {2}", value.Id, value.Jmeno, value.Prijmeni);
            }
            Console.WriteLine("Predmety studenta s id 1003");
            IEnumerable<Predmet> predmety = PredmetyStudenta(dc, 1003);
            foreach(var value in predmety)
            {
                Console.WriteLine("Skratka: {0}, Nazov: {1}", value.Zkratka, value.Nazev);
            }
            Console.WriteLine("Zoznam predmetov");
            AvgZnamka(dc);
            Console.ReadLine();
        }
    }
}

