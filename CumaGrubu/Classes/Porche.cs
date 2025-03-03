using CM19OP.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CM19OP.Classes
{
    public class Porche : Araba, IHızlıGit
    {
        public void HızlıGit(string isim)
        {
            Console.WriteLine(isim + " çok hızlı gidiyor.");
        }
    }
}
