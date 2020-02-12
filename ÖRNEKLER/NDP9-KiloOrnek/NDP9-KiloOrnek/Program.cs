using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP9_KiloOrnek
{
    class Program
    {      

        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();
            kisi.bilgiGir();
            kisi.bilgiYaz();
            Console.ReadKey();
        }
    }
}
