using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaOdev3
{
    internal class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal BenzinTuketimiPer100Km { get; set; }
        public decimal YolMesafesi { get; set; }

        public Araba(string marka, string model, decimal benzinTuketimiPer100Km, decimal yolMesafesi)
        {
            Marka = marka;
            Model = model;
            BenzinTuketimiPer100Km = benzinTuketimiPer100Km;
            YolMesafesi = yolMesafesi;
        }

        public decimal BenzinTuketiminiHesapla()
        {
            return (YolMesafesi / 100) * BenzinTuketimiPer100Km;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Marka: {Marka} - Model: {Model}");
            Console.WriteLine($"Benzin Tüketimi (100 km başına): {BenzinTuketimiPer100Km} L");
            Console.WriteLine($"Yol Mesafesi: {YolMesafesi} km");
            Console.WriteLine($"Toplam Benzin Tüketimi: {BenzinTuketiminiHesapla()} L\n");
        }
    }
}
