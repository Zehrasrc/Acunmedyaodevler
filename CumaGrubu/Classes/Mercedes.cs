using CM19OP.Abstracts;
using CM19OP.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OP.Classes
{
    public class Mercedes : Araba, IHızlıGit, IDenizdeYüz
    {
        public void HızlıGit(string isim)
        {
            Console.WriteLine(isim + " çok hızlı gidiyor.");
        }
        public void DenizdeYuz(string isim)
        {
            Console.WriteLine(isim + " denizde yüzüyor.");
        }

       
    }
}
