using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_ConditionOdevi
{
    public class Araba
    {

        public string Marka { get; set; }
        public string Model { get; set; }
        public double YakitTuketimi { get; set; }

        public Araba(string marka, string model, double yakitTuketimi)
        {
            Marka = marka;
            Model = model;
            YakitTuketimi = yakitTuketimi;
        }

        public double YakitTuketimiHesapla(double yolMesafesi)
            { 
        
                return (yolMesafesi / 100) * YakitTuketimi;
            }
        

    }
}
