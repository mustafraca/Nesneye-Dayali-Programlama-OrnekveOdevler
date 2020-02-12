using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP11_Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.bilgiYaz();
            ogrenci.bilgiGir();
            ogrenci.bilgiYaz();
            Console.ReadKey();
        }
    }
}
