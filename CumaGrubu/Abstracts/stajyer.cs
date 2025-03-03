using CM19OP.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OP.Abstracts
{
    public class Stajyer : Calisan, ICalisan
    {
        public override double maasinizNedir()
        {
            return 5000.0;
        }
    }
}
