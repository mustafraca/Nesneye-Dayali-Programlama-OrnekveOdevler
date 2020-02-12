using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP10
{
    class Hata:Exception
    {
        private int hataKodu;
        public int HataKodu
        {
            set {
                if (value < 0) hataKodu = 0;
                else hataKodu = value;
            }
            get { return hataKodu; }
        }
        public Hata() { }
        public Hata(int hataKodu)
        {
            HataKodu = hataKodu;
        }
        public void Mesaj()
        {
            switch (HataKodu)
            {
                case 0: Console.WriteLine("Genel Hata"); break;
                case 1: Console.WriteLine("Veri Giriş Hatası"); break;
                case 2: Console.WriteLine("Veri Gönderim Hatası"); break;
                default: Console.WriteLine("Farklı Bir Hata"); break;
            }
        }
    }
}
