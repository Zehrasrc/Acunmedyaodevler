using Constructor_Composition_Overloading_Odevi.Class;
using Constructor_Composition_Overloading_Odevi.Constructor;

//Ödev1
Kapı kapı = new Kapı(4);
Kasa kasa = new Kasa("Sedan");
Marka marka = new Marka("BMW");
Model model = new Model("X5");
Pencere pencere = new Pencere(4);
decimal fiyat = 2000000 ;


Kapı kapı2 = new Kapı(4);
Kasa kasa2 = new Kasa("SUV");
Marka marka2 = new Marka("Porche");
Model model2 = new Model("Macan");
Pencere pencere2 = new Pencere(4);
decimal fiyat2 = 6000000;



Araba araba = new Araba(kapı, kasa, marka, model, pencere, fiyat);
araba.Yazdir();

Console.WriteLine();

Araba ar = new Araba(kapı2, kasa2, marka2, model2, pencere2, fiyat2);
ar.Yazdir();

//Ödev 1 SON

Console.WriteLine();
Console.WriteLine();

//Ödev 2

Maths mat = new Maths();
Console.WriteLine("Toplam (int): " + mat.topla(5, 10));
Console.WriteLine("Toplam (int): " + mat.topla(5, 10, 15));
Console.WriteLine("Toplam (double): " + mat.topla(5.5, 10.5));
Console.WriteLine("Çarpma (int): " + mat.carp(5, 10));
Console.WriteLine("Çarpma (int): " + mat.topla(5, 10,5));
Console.WriteLine("Çarpma (double): " + mat.carp(5.5, 10.5, 15.5));

//Ödev 2 SON




Console.Read();