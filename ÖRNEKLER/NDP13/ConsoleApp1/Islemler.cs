using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Islemler
     {
        public int Yas;
        public int Boy;
        public string Cinsiyet;
        public int IdealKilo()
        {
           return IdealKilo(Boy, Yas, Cinsiyet);
            //if (Cinsiyet == "Kadın")
            //    return (int)((Boy - 100) * KKD + (Yas / 10.0));
            //return (int)((Boy - 100) * EKD + (Yas / 10.0));
        }

        public static double EKD = 0.9;  //erkekler için kat sayı değeri
        public static double KKD = 0.8;
        public static int IdealKilo(int boy, int yas, string cinsiyet)//static olmayan alanlara ulaşamaz
        {
           
            if (cinsiyet == "Kadın")
                return (int)((boy - 100) * KKD + (yas / 10.0));
            return (int)((boy - 100) * EKD + (yas / 10.0));
        }
     }
}
