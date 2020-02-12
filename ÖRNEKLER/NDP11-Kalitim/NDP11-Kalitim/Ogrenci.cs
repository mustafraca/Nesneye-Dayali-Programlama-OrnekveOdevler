using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP11_Kalitim
{
    class Ogrenci:Kisi
    {
        public String OgrNo { get; set; }
        public void bilgiGir()
        {
            base.bilgiGir();
            Console.Write("Numaranız: ");
            OgrNo = Console.ReadLine();
        }
        public void bilgiYaz()
        {
            base.bilgiYaz();
            Console.WriteLine("Numaranız: " + OgrNo);
        }
    }
}
