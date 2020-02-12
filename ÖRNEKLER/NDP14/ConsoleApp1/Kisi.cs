using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Kisi
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public Kisi() { }
        public Kisi(string a, string b)
        {
            ad = a; soyad = b;
        }
        public void Yaz()
        {
            Console.WriteLine(ad+" "+soyad);
        }
    }
}
