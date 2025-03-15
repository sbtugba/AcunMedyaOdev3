using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaOdev3
{
    public class ArabaDurumu
    {
        private int arabaYasi;

        public ArabaDurumu(int arabaYasi)
        {
            this.arabaYasi = arabaYasi;
        }

        public string DurumBelirle()
        {
            string durum = arabaYasi switch
            {
                int y when (y >= 0 && y <= 10) => "Arabanız yeni",
                int y when (y > 10 && y <= 20) => "Servise götürmeniz gerekebilir",
                int y when (y > 20 && y <= 30) => "Arabanız hurdaya çıkabilir",
                int y when (y < 0 || y > 30) => "Ya hiç üretilmedi ya da trafikten men edilmiştir",
                _ => "Geçersiz yaş"
            };
            return durum;
        }
    }
}
