using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaOdev3
{
    internal class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Meslek { get; set; }
        public decimal Maas { get; set; }
        public string Departman { get; set; }

        public Calisan(string ad, string soyad, string meslek, decimal maas, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Meslek = meslek;
            Maas = maas;
            Departman = departman;
        }
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad} {Soyad}");
            Console.WriteLine($"Meslek: {Meslek}");
            Console.WriteLine($"Departman: {Departman}");
            Console.WriteLine($"Maaş: {Maas:C}");
            Console.WriteLine();
        }
    }
}
