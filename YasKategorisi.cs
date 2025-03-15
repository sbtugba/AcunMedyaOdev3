using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedya3
{
    public class YasKategorisi
    {
        private int yas;

        public YasKategorisi(int yas)
        {
            this.yas = yas;
        }

        public string KategoriBelirle()
        {
            if (yas >= 0 && yas <= 18)
            {
                return "Küçüksünüz";
            }
            else if (yas >= 19 && yas <= 35)
            {
                return "Gençsiniz";
            }
            else if (yas >= 36 && yas <= 55)
            {
                return "Yetişkinsiniz";
            }
            else if (yas >= 56 && yas <= 75)
            {
                return "Yaşlısınız";
            }
            else if (yas >= 76 && yas <= 99)
            {
                return "Çok yaşlısınız";
            }
            else if (yas < 0 || yas > 99)
            {
                return "Ya hiç doğmadınız ya da çoktan öldünüz...";
            }
            else
            {
                return "Geçersiz yaş";
            }
        }
    }
}
