using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Composition_Overloading_Odevi.Class
{
    public class Maths
    {
        //iki int parametre ile toplama
        public int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        //üç int parametre ile toplama
        public int topla(int sayi1, int sayi2,int sayi3)
        {
            return sayi1 + sayi2+ sayi3;
        }
        //iki double parametre ile toplama
        public double topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
        //iki int parametre ile çarpma
        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        //üç int parametre ile çarpma
        public int carp(int sayi1, int sayi2,int sayi3)
        {
            return sayi1 * sayi2 * sayi3;
        }
        //üç double parametre ile çarpma
        public double carp(double sayi1, double sayi2,double sayi3)
        {
            return sayi1 * sayi2 * sayi3;
        }
    }
}

