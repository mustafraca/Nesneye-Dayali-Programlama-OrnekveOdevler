using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP4_CokBoyutluDiziJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            // Çok Boytutlu Dizi ( Jagged Dizi - Düzensiz Dizi)

            int[][] sayilar = new int[3][];
            int uzunluk;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}. Dizi Boyutu: ", i + 1);
                uzunluk = int.Parse(Console.ReadLine());
                sayilar[i] = new int[uzunluk];
                Console.WriteLine("-----");
                for (int j = 0; j < uzunluk; j++)
                {
                    Console.Write("{0}. Dizi Boyutunun {1}. Elemanı: ", i + 1, j + 1);
                    sayilar[i][j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("-----");
            }

            // Foreach Yapısı ile yukarıdaki Jagged diziyi yazdırma.
            for (int i = 0; i < 3; i++)
            {
                foreach (int deger in sayilar[i])
                    Console.Write(deger + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
