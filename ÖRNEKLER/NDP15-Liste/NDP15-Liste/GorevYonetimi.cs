using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP15_Liste
{
    class GorevYonetimi
    {
        private Liste<int> liste;
        private int secim;
        public GorevYonetimi()
        {
            liste = new Liste<int>();
        }
        public GorevYonetimi(int gorevsayisi)
        {
            liste = new Liste<int>(g);
        }
        private int Menu()
        {
            Console.Clear();
            Console.WriteLine("Görev Yönetim Uygulaması");
            Console.WriteLine("1-Görev Ekle");
            Console.WriteLine("2-Görev Listele");
            Console.WriteLine("3-Görev Sayısı");
            Console.WriteLine("9-Çıkış");
            Console.Write("Seçiminiz:");
            return int.Parse(Console.ReadLine());
        }
        private void Islem()
        {
            switch(secim)
            {
                case 1:
                    Console.Write("Görev Numarası: ");
                    liste.Ekle(int.Parse(Console.ReadLine()));
                    break;
                case 2:
                    for (int i = 0; i < liste.ElemanSayisi; i++)
                        Console.WriteLine("Görev " + i + ": " + liste.Getir(i));
                    break;
                case 3:
                    Console.WriteLine("Görev Sayısı: " + liste.ElemanSayisi);
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("Yanlış Seçim");
                    break;
            }
        }
        public void Calistir()
        {
            do
            {
                secim = Menu();
                Islem();
                Console.WriteLine("Devam Etmek İçin Bir Tuşa Basınız...");
                Console.ReadKey();
            } while (secim != 9);
        }
    }
}
