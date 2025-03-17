using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Composition_Overloading_Odevi.Constructor
{
    public class Araba
    {
        public Kapı kapı;
        public Kasa kasa;
        public Marka markasi;
        public Model modeli;
        public Pencere pencere;
        public decimal fiyat;

        

        public Araba(Kapı kapı, Kasa kasa, Marka marka, Model model, Pencere pencere, decimal fiyat)
        {
            this.pencere = pencere;
            this.kapı=kapı;
            this.kasa = kasa;
            this.markasi = marka;
            this.modeli = model;
            this.fiyat = fiyat;
        }

        public void Yazdir()
        {
            Console.WriteLine("Arabanın markası:" + markasi.marka +" ,"+
                "modeli:" + modeli.modeli+" ," + "kapı sayısı:" + kapı.kapıSayisi + " ,"+
                "pencere sayısı: " + pencere.pencereSayisi + " ,"+ "kasası:" + kasa.kasa + " ,"+
                "fiyatı: " + fiyat + " TL");
        }
    }
}
