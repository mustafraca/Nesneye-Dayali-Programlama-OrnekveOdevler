using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP2_KosulOpertaoru
{
    class Program
    {
        static void Main(string[] args)
        {
            // Koşul Operatörü Kullanımı.
            Console.Write("Not Ortalamanız: ");
            int ort = int.Parse(Console.ReadLine());
            string durum = (ort >= 50) ? "Geçti" : "Kaldı";
            Console.WriteLine("Durumunuz: " + durum);
            Console.ReadKey();
        }
    }
}
