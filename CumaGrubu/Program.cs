// See https://aka.ms/new-console-template for more information
using CM19OP.Abstracts;
using CM19OP.Classes;
using CumaGrubu.Classes;

Console.WriteLine("Hello, World!");


//bir class tan nesne oluşturma 
//classIsmi nesneAdi = new ClassIsmi();

Insan i = new Insan();
i.adi = "Hakan";
i.soyadi = "Yılmaz";
i.yas = 46;
i.maas = 3.14;
i.cinsiyet = true;
//bir metodu çağırmış olduk
i.uyu("metin");
i.uyu(i.adi);

Araba a = new Araba();
a.marka = "Bmw";
a.model = "x5";
a.kapiSayisi = 4;
a.pencereSayisi = 4;
a.git("Mercedes");
a.git(a.marka);



Matematik m = new Matematik();
//1.yöntem
int gelenDeğer = m.topla(5, 5);
Console.WriteLine("Toplam: " + gelenDeğer);

//2. yöntem
Console.WriteLine("Toplam 2.yöntem : " +m.topla(10, 10) );

Console.WriteLine("Çıkan sonuç: " + m.cikar(10, 10));

Console.WriteLine("Çarpım sonuç: " + m.carp(10, 10) );

Console.WriteLine("Bölüm sonuç: " + m.bol(10, 10));


Anne an  = new Anne();
an.adi = "Leyla";
an.soyadi = "Serçe";
an.ekranaYaz(an.adi, an.soyadi);
an.oku(an.adi);
an.yaz("Leyla");
an.dinle("Leyla");

Baba b = new Baba();
b.ekranaYaz("Nesim", "Serçe");
b.oku("Nesim");

Cocuk c = new Cocuk();
c.ekranaYaz("Zehra", "Serçe");


Porche p = new Porche();
p.markaModelYaz("Porche", "carrera");

Bmw bm = new Bmw();
bm.markaModelYaz("Bmw", "X5");

Mercedes me = new Mercedes();
me.markaModelYaz("Mercedes", "XL");

AkilliCocuk ak = new AkilliCocuk();
ak.adi = "Hakan";
ak.soyadi = "Yılmaz";
ak.sifat = "Akıllıdır";
ak.adSoyadSifatYaz(ak.adi, ak.soyadi, ak.sifat);
ak.askeregit(ak.adi);
ak.ehliyetAl(ak.adi);
ak.klubeGit(ak.adi);


UsluCocuk us = new UsluCocuk();
us.adSoyadSifatYaz("Mehmet", "Yıldız", "Usludur");
us.askeregit("Mehmet");
us.ehliyetAl("Mehmet");

#region
Audi au = new Audi();
au.markaVitesYaz("Audi" ,"Düz viteslidir.");

Bmw bmw = new Bmw();
bmw.markaVitesYaz("BMW", "Düz viteslidir.");

Porche por = new Porche();
por.markaVitesYaz("Porche", "Otomatik viteslidir.");

Togg to = new Togg();
to.markaVitesYaz("Togg", "Elektriklidir.");

Toyota toy = new Toyota();
toy.markaVitesYaz("Toyota", "Otomatik viteslidir.");

Mercedes mer = new Mercedes();
mer.markaVitesYaz("Mercedes", "Otomatik viteslidir.");
#endregion   

Hiperaktif hp = new Hiperaktif();
hp.ehliyetAl("Hüseyin");

//abstract class ların instance yani örneği oluşturulamaz
//Calisan ca = new Calisan();

GenelMudur gn = new GenelMudur();
Mudur mu = new Mudur();
Programci pr = new Programci();
stajyer s = new stajyer();

double toplamMaas = 0.0;
//toplamMaas = toplamMaas + gn.maasinizNedir();
toplamMaas += gn.maasinizNedir();
toplamMaas += mu.maasinizNedir();
toplamMaas += pr.maasinizNedir();
toplamMaas -= s.maasinizNedir();
 
Console.WriteLine("Toplam: " +  toplamMaas + " TL maaş alıyorlar");