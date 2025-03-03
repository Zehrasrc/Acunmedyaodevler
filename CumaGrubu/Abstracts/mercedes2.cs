using CM19OP.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OP.Abstracts
{
    public class mercedes2 : Abstract_Araba, IYakit
    {
        public override double ToplamYakitMiktari()
        {
            return 70.0;
        }
    }
}
