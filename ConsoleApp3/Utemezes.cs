using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Utemezes
    {
        public int HoKezdet { get; set; }
        public int NapKezdet { get; set; }
        public int HoVege {  get; set; }
        public int NapVege { get; set; }

        public string KezdoBetu { get; set; }
        public string Tema {  get; set; }


        public Utemezes(string v) 
        {
            string[] adatok = v.Split('\t');
            HoKezdet = int.Parse(adatok[0]);
            NapKezdet = int.Parse(adatok[1]);
            HoVege = int.Parse(adatok[2]);
            NapVege = int.Parse(adatok[3]);
            KezdoBetu = adatok[4];
            Tema = adatok[5];

        }
    }
}
