﻿using CM19OP.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CM19OP.Abstracts
{
    public abstract class Abstract_Araba : IYakit
    {
        public abstract double ToplamYakitMiktari();
        
    }
}
