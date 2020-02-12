using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare();
           /* Nokta nokta = new Nokta();
            nokta.X = 1;
            nokta.Y = 4;
            kare.BN=*/
            kare.BN = new Nokta(1, 4);
            kare.kenarU = 5;
            Console.Write("karenin alanı: " + kare.Alan);
            Console.Write("karenin cevresi: " + kare.Cevre);

            Daire daire = new Daire();
            daire.MNokta = new Nokta(5, 8);
            daire.R = 5;
            Console.Write("karenin alanı: " + daire.Alan);
            Console.Write("karenin cevresi: " + daire.Cevre);

            Sekil[] sekiller = new Sekil[2];
            sekiller[0]= kare;
            sekiller[1] = daire;
            foreach(Sekil sekil in sekiller)
            {
                Console.Write("karenin alanı: " + sekil.Alan);
                Console.Write("karenin cevresi: " + sekil.Cevre);
            }


            /*
            Islemler islem = new Islemler();
            islem.Boy = 185;
            islem.Yas = 25;
            islem.Cinsiyet = "Erkek";

            Console.WriteLine("erkekler için kat sayı değeri: " +  Islemler.EKD);
            Console.WriteLine("kadınlar için kat sayı değeri: " + Islemler.KKD);

            Console.WriteLine("ideal kilonuz: " + Islemler.IdealKilo(168, 40, "Kadın"));
            Console.WriteLine("ideal kilonuz: "+islem.IdealKilo());*/

            Console.ReadLine();
        }
    }
}
