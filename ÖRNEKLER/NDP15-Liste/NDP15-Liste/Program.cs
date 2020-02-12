using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP15_Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Görev Sayısı: ");
            int gorevsayisi = int.Parse(Console.ReadLine());
            GorevYonetimi g;
            if (gorevsayisi >= 5) g = new GorevYonetimi(gorevsayisi);
            else g = new GorevYonetimi();
            g.Calistir();
        }
    }
}
