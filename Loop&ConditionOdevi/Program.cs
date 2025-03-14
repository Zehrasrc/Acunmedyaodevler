using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Loop_ConditionOdevi
{
     class Program
    {
        // Ödev 1
        
        public static string YasMesaji(int yas)
        {
            if (yas >= 0 && yas < 18)
                return "Küçüksünüz";

            else if (yas >= 18 && yas < 35)
                return "Gençsiniz";

            else if (yas >= 35 && yas < 55)
                return "Yetişkinsiniz";

            else if (yas >= 55 && yas < 75)
                return "Yaşlısınız";

            else if (yas >= 75 && yas <= 99)
                return "Çok yaşlısınız";

            else if (yas < 0 && yas > 99)
                return "Ya hiç doğmadınız ya da çoktan öldünüz...";

            return "";
        }
        
        
         //Ödev 2   
        static string ArabaDurumu(int yasi)
        {
            if (yasi >= 0 && yasi <= 10)
                return "Arabanız yeni";
            
            else if (yasi > 10 && yasi <= 20)
                return "Servise götürmeniz gerekebilir";
            
            else if (yasi > 20 && yasi <= 30)
                return "Arabanız hurdaya çıkabilir";
            
            else if (yasi < 0 || yasi > 30)
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            
            else
                return "Geçersiz yaş";
        }
        static void Main()
        {
            Console.Write("Yaşınızı girin:");
            int yas = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(YasMesaji(yas));

            Console.Write("Araba yaşını giriniz: ");
            int yasi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(ArabaDurumu(yasi));
            Console.WriteLine();

            //Ödev 4
            List<Calisan> calisanlar = new List<Calisan>();
            calisanlar.Add(new Calisan("Ahmet", "Yılmaz", "Genel Müdür", "Finans", 300000));
            calisanlar.Add(new Calisan("Ayşe", "Kara", "Müdür", "Ar-Ge", 250000));
            calisanlar.Add(new Calisan("Mehmet", "Demir", "Programcı", "IT", 175000));
            calisanlar.Add(new Calisan("Zeynep", "Çelik", "Stajyer", "Medya", 125000));

            decimal toplamMaas = 0;
            foreach (var calisan in calisanlar)
            {
                Console.WriteLine(calisan.MaasBilgi());
                toplamMaas += calisan.Maas;  
            }

            Console.WriteLine($"Toplam maaş: {toplamMaas} TL");
            Console.WriteLine();

            //Ödev 5
            List<Araba> arabalar = new List<Araba>();

            arabalar.Add(new Araba("Porsche", "Cayenne", 10.5));
            arabalar.Add(new Araba("Range Rover", "Evoque", 8.0));
            arabalar.Add(new Araba("Mini Cooper", "S", 6.2));
            arabalar.Add(new Araba("Audi", "A6", 7.8));

            double toplamYakitTuketimi = 0;
            double yolMesafesi = 1500;

            foreach (var araba in arabalar)
            {
                double benzinTuketimi = araba.YakitTuketimiHesapla(yolMesafesi);
                Console.WriteLine($"{araba.Marka} {araba.Model} arabası {yolMesafesi} km yol alırken {benzinTuketimi} litre benzin tüketecek.");
                toplamYakitTuketimi += benzinTuketimi;
            }

            Console.WriteLine($"Tüm arabaların toplam benzin tüketimi: {toplamYakitTuketimi} litre");
        }
    }
}

        
         

    
    






