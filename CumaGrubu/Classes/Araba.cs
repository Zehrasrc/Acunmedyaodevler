using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OP.Classes
{
    public class Araba
    {

        public string marka = null;
        public string model = null;
        public int kapiSayisi = 0;
        public int pencereSayisi = 0;
        public string vites = null;
         //metotlar
        public void git(string markasi)
        {
            Console.WriteLine(markasi + " gidiyor...");
        }

        public void markaModelYaz(string markasi, string model)
        {
            Console.WriteLine("Markası: " + markasi +" - " + "Modeli: " + model);
        }

        public void markaVitesYaz(string markasi ,string vites)
        {
            Console.WriteLine(markasi + " -- "  + vites);
        }
    }
}
