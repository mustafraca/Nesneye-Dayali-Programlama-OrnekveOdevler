using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP10
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim = 0;
            Kisi kisi = new Kisi();
            do
            {
                try
                {
                    Console.Clear();
                    kisi.bilgiGir();
                    kisi.bilgiYaz();
                }
                catch (Hata e)
                {
                    e.Mesaj();
                }
                catch
                {
                    Console.WriteLine("Hata Var.");
                }
                Console.Write("Devam Etmek İstiyor musun? (Evet: 1) : ");
                secim = int.Parse(Console.ReadLine());
            } while (secim == 1);
            Console.ReadKey();
        }
    }
}
