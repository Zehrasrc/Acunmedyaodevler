using System;
using System.Collections.Generic;

class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public double BenzinHarcaması { get; set; }
    public double ToplamMesafe { get; set; }

    public Araba(string marka, string model, double benzinHarcaması, double toplamMesafe)
    {
        Marka = marka;
        Model = model;
        BenzinHarcaması = benzinHarcaması;
        ToplamMesafe = toplamMesafe;
    }

    public double ToplamBenzinTüketimi()
    {
        return (ToplamMesafe / 100) * BenzinHarcaması;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Araba araba1 = new Araba("Toyota", "Corolla", 6.5, 5000);
        Araba araba2 = new Araba("BMW", "X5", 9.0, 5000);
        Araba araba3 = new Araba("Mercedes", "C200", 8.2, 5000);

        List<Araba> arabalar = new List<Araba> { araba1, araba2, araba3 };

        foreach (var araba in arabalar)
        {
            double toplamBenzin = araba.ToplamBenzinTüketimi();
            Console.WriteLine("Marka: " + araba.Marka + ", Model: " + araba.Model +
                              ", 100 km'de Yaktığı Yakıt: " + araba.BenzinHarcaması +
                              " litre, Toplam Yakıt Tüketimi: " + toplamBenzin + " litre");
        }
        Console.ReadLine();
    }
    
}
