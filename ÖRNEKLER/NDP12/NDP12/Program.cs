using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP12
{
    class Program
    {
        static void Main(string[] args)
        {
            IOgrenci[] ogrenciler = new IOgrenci[2];
            LOgrenci logrenci = new LOgrenci();
            Console.Write("Öğrencinin İsmi: ");
            logrenci.Isim = Console.ReadLine();
            Console.Write("Öğrencinin Yaşı: ");
            logrenci.Yas = int.Parse(Console.ReadLine());
            Console.Write("Numarası: ");
            logrenci.OgrNo = Console.ReadLine();

            ogrenciler[0] = logrenci;

            YOgrenci yogrenci = new YOgrenci();
            Console.Write("Öğrencinin İsmi: ");
            yogrenci.Isim = Console.ReadLine();
            Console.Write("Öğrencinin Yaşı: ");
            yogrenci.Yas = int.Parse(Console.ReadLine());
            Console.Write("Numarası: ");
            yogrenci.OgrNo = Console.ReadLine();

            ogrenciler[1] = yogrenci;

            for (int i = 0; i < 2; i++)
                Console.WriteLine(ogrenciler[i].OgrNo);

            Console.ReadKey();
        }
    }
}
