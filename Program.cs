using AcunMedya3;
using System.Reflection;

namespace AcunMedyaOdev3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int yas = 25;  
            YasKategorisi kategori = new YasKategorisi(yas);
            Console.WriteLine(kategori.KategoriBelirle());

            Console.WriteLine();
            int arabaYasi = 25;  
            ArabaDurumu araba = new ArabaDurumu(arabaYasi);
            Console.WriteLine(araba.DurumBelirle());

            Console.WriteLine();
            int sayac = 0;
            while (sayac < 3)
            {
                Console.WriteLine("While döngüsü çalışıyor. Sayac: " + sayac);
                sayac++;
            }

            Console.WriteLine();
            do
            {
                Console.WriteLine("Do-While döngüsü çalışıyor. Sayac: " + sayac);
                sayac++;
            }
            while (sayac < 3);

            Console.WriteLine();
            Calisan genelMudur = new Calisan("Ahmet", "Yılmaz", "Genel Müdür", 20000, "Yönetim");
            Calisan mudur = new Calisan("Mehmet", "Kara", "Müdür", 15000, "Pazarlama");
            Calisan programci = new Calisan("Ayşe", "Demir", "Programcı", 8000, "Yazılım");
            Calisan stajyer = new Calisan("Ali", "Çelik", "Stajyer", 3000, "Yazılım");

            List<Calisan> calisanlar = new List<Calisan> { genelMudur, mudur, programci, stajyer };
            decimal toplamMaas = 0;

            foreach (var calisan in calisanlar)
            {
                calisan.BilgileriYazdir();
                toplamMaas += calisan.Maas;
            }
            Console.WriteLine($"Toplam maaş: {toplamMaas:C}");

            Console.WriteLine();
            Araba araba1 = new Araba("Toyota", "Corolla", 7.5m, 150);
            Araba araba2 = new Araba("Ford", "Focus", 8.0m, 200);
            Araba araba3 = new Araba("BMW", "3 Serisi", 9.0m, 120);

            List<Araba> arabalar = new List<Araba> { araba1, araba2, araba3 };

            decimal toplamBenzinTuketimi = 0;

            foreach (var arabaObjesi in arabalar)
            {
                arabaObjesi.BilgileriYazdir();
                toplamBenzinTuketimi += arabaObjesi.BenzinTuketiminiHesapla();
            }

            Console.WriteLine($"Toplam Benzin Tüketimi: {toplamBenzinTuketimi} L");
        }
    }
}
