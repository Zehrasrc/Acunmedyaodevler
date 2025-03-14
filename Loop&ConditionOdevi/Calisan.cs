using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_ConditionOdevi
{
public class Calisan  
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Meslek { get; set; }
        public string Departman { get; set; }
        public decimal Maas { get; set; }

        public Calisan(string ad, string soyad, string meslek, string departman, decimal maas)
        {
            Ad = ad;
            Soyad = soyad;
            Meslek = meslek;
            Departman = departman;
            Maas = maas;
        }
        public virtual string MaasBilgi()
        {
            return $"{Ad} {Soyad}, {Meslek} - Departman: {Departman}, Maaş: {Maas} TL";
        }
    }



}

