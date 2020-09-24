using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Console.ReadKey();
        }

        private static void Feladat6()
        {
            Console.WriteLine("6.Feladat: magasság");
            Console.Write("Kérem adja meg a nevét: ");
            string Nev = Console.ReadLine();
            Console.Write("Kérem adja meg a magasságát méterben: ");
            double MagassagM = double.Parse(Console.ReadLine());
            double MagassagCM = MagassagM * 100;
            if(MagassagCM<90)
            { Console.WriteLine("Sajnos {0}, Ön rettentően alacsony",Nev); }
            if(90<=MagassagCM && MagassagCM<120)
            { Console.WriteLine("Sajnos {0}, Ön eléggé alacsony", Nev); }
            if (120 <= MagassagCM && MagassagCM < 150)
            { Console.WriteLine("Sajnos {0}, Ön  alacsony", Nev); }
            if (150 <= MagassagCM && MagassagCM < 180)
            { Console.WriteLine("Sajnos {0}, Ön   normál magasságú", Nev); }
            if (180 <= MagassagCM && MagassagCM < 210)
            { Console.WriteLine("Sajnos {0}, Ön   nagyon magas", Nev); }
            if (210 <= MagassagCM)
            { Console.WriteLine("Sajnos {0}, Ön   rendkívül maga", Nev); }

        }

        private static void Feladat5()
        {
            Console.WriteLine("5.Feladat: Kocka térfogata, felszíne");
            Console.Write("Kérem adja meg az oldal hosszát: ");
            double Aoldal = double.Parse(Console.ReadLine());
            double Felszin = 6 * Aoldal * Aoldal;
            Console.WriteLine("A kocka felszíne: {0}", Felszin);
            double Terfogat = Aoldal * Aoldal * Aoldal;
            Console.WriteLine("A kocka téfogata: {0}", Terfogat);
            double Rsugar = (Math.Sqrt(3) / 2) * Aoldal;
            Console.WriteLine("A kocka köré írt gömb sugara: {0}", Rsugar);
            double rsugar = Aoldal / 2;
            Console.WriteLine("A kockába írt gömb sugara: {0}", rsugar);
        }

        private static void Feladat4()
        {
            Console.WriteLine("4.Feladat: kocka dobások különbsége");
            int Kocka1;
            int Kocka2;
            int db = 0;
            for (int i = 1; i <= 7; i++)
            {
                Kocka1 = rnd.Next(1, 7);
                Kocka2 = rnd.Next(1, 7);
                if(Math.Abs(Kocka1-Kocka2)==2)
                {
                    db++;
                }
                Console.WriteLine("{0}. dobás -> kocka1: {1} - kocka2: {2}", i, Kocka1, Kocka2);
            }
            Console.WriteLine("Ennyi alkalommal volt a dobás különbség 2: {0}", db);

        }

        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat: ásványvíz\n");
            double AsvanyiAnyagTartalom;
            double Osszeg = 0;
            double Atlag = 0;
            int db = 0;
            for(int i=1; i<=28; i++)
            {
                AsvanyiAnyagTartalom = rnd.Next(62, 86);
                Osszeg += AsvanyiAnyagTartalom;
                Console.WriteLine("\t{0:00} kút ásványanyag tartalma: {1}", i, AsvanyiAnyagTartalom);
                if(AsvanyiAnyagTartalom>80)
                {
                    db++;
                }                
            }
            Atlag = Osszeg / 28;
            Console.WriteLine("\tA kutak össz ásvány anyag tartalma a mintában: {0}", Osszeg);
            Console.WriteLine("\tA kutak ásványi anyag tartalamának átlaga a mintában: {0}", Atlag);
            Console.WriteLine("\tEnnyi alkalommal volt 80mg/l feletti az sványi anyag tartalom: {0}", db);
            
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat: háromszög területe");
            eleje:
            Console.Write("Kérem adja meg a háromszög a oldalát: ");
            double Aoldal = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a háromszög a oldalát: ");
            double Boldal = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a háromszög a oldalát: ");
            double Coldal = double.Parse(Console.ReadLine());
            if(Aoldal+Boldal>Coldal && Aoldal+Coldal>Boldal && Boldal+Coldal>Aoldal )
            {
                Console.WriteLine("Létetik ilyen háromszög és ki tudom számítani a területét");
                double Sertek = (Aoldal + Boldal + Coldal) / 2;
                double Terulet = Math.Sqrt(Sertek * (Sertek - Aoldal) * (Sertek - Boldal) * (Sertek - Coldal));
                Console.WriteLine("A háromszög területe: {0}", Terulet);
            }
            else
            {
                Console.WriteLine("Sajnálom nem jó háromszöget adott meg");
                Console.Clear();
                goto eleje;
            }
        }

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat ");
            for (int i = 10000; i <= 99999; i++)
            {
                if(i%12==0)
                {                    
                    if (i%9==0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                       
                    }
                    Console.Write("{0} , ", i);
                    Console.ResetColor();
                }
            }
        }
    }
}
