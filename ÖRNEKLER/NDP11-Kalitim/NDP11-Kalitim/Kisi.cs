using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP11_Kalitim
{
    class Kisi
    {
        private string isim = "İsim Yok";
        public string Isim
        {
            set { isim = value; }
            get { return isim; }
        }
        private int yas;
        public int Yas
        {
            set { yas = value; }
            get { return yas; }
        }
        public void bilgiGir()
        {
            Console.Write("İsminiz: ");
            Isim = Console.ReadLine();
            Console.Write("Yaşınız: ");
            Yas = Convert.ToInt32(Console.ReadLine());
        }
        public void bilgiYaz()
        {
            Console.WriteLine("İsminiz: " + Isim);
            Console.WriteLine("Yaşınız: " + Yas);
        }
    }
}
