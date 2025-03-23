
using ConsoleApp2.ErisimBelirleyiciler;
using MyNamespace;

#region Erisim Belirleyiciler
User user = new();
user.AdSoyad = "Fatih Bozkurt";
user.Yas = 21;
user.Email = "fatihbozkurt@gmail.com";

user.BilgileriGoster();
#endregion
#region Namespace
Hesaplama hesaplama = new();
hesaplama.Topla(3, 5);
hesaplama.Carp(3, 5);
#endregion
#region MerhabaDünya
Console.WriteLine("Merhaba Dünya!");
#endregion
#region Sayı Tahmin

Random random = new();
long number = random.Next(0, 100);

int guessNumber = -1;
while (true)
{
    Console.Write("Sayı Giriniz :");
    guessNumber = int.Parse(Console.ReadLine());

    if (guessNumber < number)
    {
        Console.WriteLine("Yukarı");
    }
    else if (guessNumber > number)
    {
        Console.WriteLine("Aşağı");
    }
    else
    {
        Console.WriteLine("Sayıyı Doğru tahmin ettiniz.");
        break;
    }
}

#endregion
#region Diziler Ve Döngüler

int[] sayilar = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i + 1 + ". Sayı Giriniz: ");
    if (int.TryParse(Console.ReadLine(), out int sayi))
        sayilar[i] = sayi;
    else
        i -= 1;
}

int toplam = 0;
foreach (var item in sayilar)
{
    toplam += item;
}

Console.WriteLine(toplam);
Console.WriteLine(toplam / sayilar.Length);

#endregion