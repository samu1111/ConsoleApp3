using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var adat = new List<Utemezes>();
            StreamReader sr = new StreamReader(@"taborok.txt");
            while (!sr.EndOfStream)
            {
                adat.Add(new Utemezes(sr.ReadLine()));
            }

            Console.WriteLine("2. feladat:");
            Console.WriteLine($"Az adatsorok száma: {adat.Count}");
            Console.WriteLine($"Az először rögzített tábor témája:  {adat[0].Tema} ");
            Console.WriteLine($"Az utoljára rögzített tábor témája: {adat[adat.Count - 1].Tema}");
            Console.WriteLine("3. feladat:");
            foreach (var tabor in adat)
            {
                if (tabor.Tema == "zenei")
                {
                    Console.WriteLine($"Zenei tábor kezdődik {tabor.HoKezdet}. hó {tabor.NapKezdet}. napján.");
                }

                
            }
            Console.WriteLine("4. feladat:");
            
            int kezdho = 0; 
            int kezdnap = 0;
            int max = 10;
            string tema = "";

            foreach (var tabor in adat)
            {
                if (max < tabor.KezdoBetu.Length)
                {
                    kezdho = tabor.HoKezdet;
                    kezdnap = tabor.NapKezdet;
                    tema = tabor.Tema;
                }
            }
            Console.WriteLine("Legnépszerűbbek:");
            Console.WriteLine(kezdho + " " + kezdnap + " " + tema);



            Console.WriteLine("6. feladat:");
            Console.Write("hó:");
            int ho = int.Parse(Console.ReadLine());
            Console.Write("nap:");
            int nap = int.Parse(Console.ReadLine());

            int szam = 0;
            foreach (Utemezes tabor in adat)
            {
                if (ho == tabor.HoKezdet || nap == tabor.NapKezdet) szam++;
                
                
                
            }
            Console.WriteLine($"Ekkor éppen {szam} tábor tart.");




            Console.ReadKey();
        }

        private int sorszam(int honap, int nap)
        {
            DateTime kezdes = new DateTime(2024, 6, 16);
            DateTime most = new DateTime(2024, honap, nap);
            TimeSpan Nyarnap = most - kezdes;

            return Nyarnap.Days;
        }

    }
}
