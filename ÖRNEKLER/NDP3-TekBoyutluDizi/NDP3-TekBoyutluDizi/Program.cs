using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP3_TekBoyutluDizi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tek Boyutlu Dizi

            int uzunluk;
            Console.Write("Dizinin Eleman Sayısı: ");
            uzunluk = int.Parse(Console.ReadLine());
            int[] sayilar = new int[uzunluk];
            for (int i = 0; i < uzunluk; i++)
            {
                Console.Write("{0}. Sayı = ", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            for (int i = 0; i < uzunluk; i++) toplam += sayilar[i];
            double ortalama = (double)toplam / uzunluk;
            Console.WriteLine("Sayıların Ortalaması: " + ortalama);
            Console.ReadKey();
        }
    }
}
