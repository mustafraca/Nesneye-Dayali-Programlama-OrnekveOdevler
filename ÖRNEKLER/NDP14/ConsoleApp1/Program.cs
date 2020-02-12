using System;
using System.Collections;//list için
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
            Sayi<string> sayi2 = new Sayi<string>();
            sayi2.eleman = "ali";

            Sayi<int> sayi1 = new Sayi<int>();
            sayi1.eleman=5;

            Sayi<Kisi> kisi1 = new Sayi<Kisi>();
          


            ArrayList liste = new ArrayList();//obje türünde eleman saklar
            liste.Add(5);
            liste.Add(5.7);
            liste.Add("ali");
            liste.Add(new Kisi("ali", "gel"));
            liste.Add("ali");
            liste.Add("veli");
            liste.Add("nur");

            for (int i = 0; i < liste.Count; i++)
                Console.WriteLine(liste[i]);

            Console.WriteLine("eleman sayısı: " + liste.Count);
            foreach (var deger in liste)
                Console.WriteLine(deger);
            Console.WriteLine("-------------------");

            liste.RemoveAt(3);//at indeks ile işlem yapıyor indesktekini sil
            liste.Remove("ali");//ilk ali 'yi siler

            Console.WriteLine("eleman sayısı: " + liste.IndexOf(2));//2.indeksdeteki elemanı getirir.
            foreach (var deger in liste)
                Console.WriteLine(deger);




            /* int sonuc = 0;
             foreach(var deger in liste)
             {
                 sonuc += (int)deger;
                 Console.WriteLine((deger.ToString()).Substring(0, 1));
             }
             Console.WriteLine("sonuc:" + sonuc);*/



            /*
            object[] sayilar = new object[4];
            sayilar[0]=5;
            sayilar[1] = 7.4;
            sayilar[2] = "ali";
            sayilar[3] = new Kisi("ali","gel");
            double sonuc= 0;
            /*
            int n;
            Console.WriteLine("eleman sayısı:");
            n = int.Parse(Console.ReadLine());
            object[] sayilar = new object[n];
            for (int i = 0; i < n; i++)
                sayilar[i]=i;
            foreach (var deger in sayilar)
            {
                Kisi kisi = (Kisi)deger;
                sonuc += int.Parse(deger.ToString());
            }
            Console.WriteLine("sonuc:" +sonuc);*/

            Console.ReadKey();
        }
    }
}
