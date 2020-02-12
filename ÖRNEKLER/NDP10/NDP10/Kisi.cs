using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP10
{
    class Kisi
    {
        private string isim = "Veri Yok";
        public string Isim
        {
            get
            {
                return "Sayın " + isim;
            }
            set
            {
                if (value.Length < 2) throw new Hata(1);
                else if (value.Length > 15) { isim = value.Substring(0, 14); }
                else isim = value;
            }
        }
        private int cinsiyet;
        public string Cinsiyet
        {
            get
            {
                if (cinsiyet == 1) return "Kadın";
                return "Erkek";
            }
            set
            {
                if (value.ToLower() == "kadın" || value.ToLower() == "kadin") cinsiyet = 1;
                else if (value.ToLower() == "erkek") cinsiyet = 2;
                else throw new Hata(1);
            }
        }
        private int boy;
        public int Boy
        {
            get { return boy; }
            set
            {
                if (value < 150 || value > 250) throw new Hata(1);
                boy = value;
            }
        }
        private int yas;
        public int Yas
        {
            get { return yas; }
            set
            {
                if (value < 18 || value > 80) throw new Hata(1);
                yas = value;
            }
        }
        public int getIdealKilo()
        {
            if (Cinsiyet == "Kadın") return int.Parse(Math.Round((Boy - 100) * 0.8) + (Yas / 10.0).ToString());
            return int.Parse(Math.Round((Boy - 100) * 0.9) + (Yas / 10.0).ToString());
        }

        public void bilgiYaz()
        {
            Console.WriteLine("Sayın " + Isim);
            Console.WriteLine("Boyunuz: " + Boy);
            Console.WriteLine("Yaşınız: " + Yas);
            Console.WriteLine("Cinsiyetiniz: " + Cinsiyet);
            Console.WriteLine("İdeal Kilonuz: " + getIdealKilo());
        }

        public void bilgiGir()
        {
            Console.Write("İsminiz: ");
            Isim=Console.ReadLine();
            Console.Write("Boyunuz: ");
            Boy=int.Parse(Console.ReadLine());
            Console.Write("Yaşınız: ");
            Yas=int.Parse(Console.ReadLine());
            Console.Write("Cinsiyetiniz: ");
            Cinsiyet = Console.ReadLine(); ;
        }
    }
}
