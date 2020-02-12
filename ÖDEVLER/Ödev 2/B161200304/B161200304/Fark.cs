using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B161200304
{
    class Fark
    {
        private static int xyeni, yyeni;
        public int getXyeni
        {
            get { return xyeni; }
        }
        public int getYyeni
        {
            get { return yyeni; }
        }

        public int XYGir(int taban, int tavan)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi >= taban && sayi <= tavan)
                return sayi;
            Console.Write("Aralık Dışında Giriş! Yeni Giriş Yapınız. (" + taban + "-" + tavan + "): ");
            return XYGir(taban, tavan);
        }

        public void Birlestir()
        {
            Yaz yaz = new Yaz();
            yaz.RandomYaz();
            Console.Write("Xyeni Değeri (500-999 Arası): ");
            xyeni = XYGir(500, 999);
            Console.Write("Yyeni Değeri (1000-1499 Arası): ");
            yyeni = XYGir(1000, 1499);
            Oku oku = new Oku();
            oku.OkuHesapla();
            Sirala sirala = new Sirala();
            sirala.KBSirala();
        }
    }
}
