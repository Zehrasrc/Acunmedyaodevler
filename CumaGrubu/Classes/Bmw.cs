using CM19OP.Abstracts;
using CM19OP.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OP.Classes
{
    public class Bmw : Araba , IHızlıGit, IDenizdeYüz, IHavadaUc
    {
        public void HızlıGit(string isim)
        {
            Console.WriteLine(isim + " çok hızlı gidiyor.");
        }

        public void DenizdeYüz(string isim)
        {
            Console.WriteLine(isim + " denizde yüzüyor.");
        }

        public void HavadaUc(string isim)
        {
            Console.WriteLine(isim + " havada uçuyor..");
        }

        

       
    }
}
