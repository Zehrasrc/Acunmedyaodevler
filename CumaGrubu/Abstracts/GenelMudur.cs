using CM19OP.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OP.Abstracts
{
    public class GenelMudur : Calisan , ICalisan
    {
        public override double maasinizNedir()
        {
            return 80000.0;
        }

        
    }
}
