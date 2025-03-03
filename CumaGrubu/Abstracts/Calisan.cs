
using CM19OP.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OP.Abstracts
{
    //1. abstract class ların nesnesi oluşturulamaz
    //2. abstract class ın kendisinden türeyen classları eğer abstract class içinde normal metodların dışında
    //3. abstract keyword ile tanımlanmış bir metod varsa o metodu yazmak zorundadırlar.
    public abstract class Calisan : ICalisan
    {
        public abstract double maasinizNedir();

       
    }
}