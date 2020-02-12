using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP1_UcgeninKosegenUzunluklari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Üçgenin Köşegen Uzunluklarını bulmak.

            int a, b, c;
            Console.Write("Üçgenin Kenar Uzunlukları: ");
            a = Convert.ToInt32(Console.ReadLine()); // int.Parse(Console.ReadLine()); yöntemide kullanılabilir.
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            double u = (a + b + c) / 2.0; // 2'ye böldüğümüzde virgülden sonraki veri kaybolur. Bunun için dönüşüm yapmak gerekir. 2.0 kullanımı veya (double)2 olarakta kullanılabilir.
            double k = 2 * Math.Sqrt(u * (u - a) * (u - b) * (u - c));
            double ha = k / a;
            double hb = k / b;
            double hc = k / c;

            Console.WriteLine("hA = " + ha);
            Console.WriteLine("hB = " + hb); // Console.WriteLine("hB = {0}", hb); kullanımıda alternatiftir.
            Console.WriteLine("hC = " + hc); // |-> Console.WriteLine("{0} = {1}", "hC", hc);
            Console.ReadKey();
        }
    }
}
