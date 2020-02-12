using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP5_CharStringTanimlamalari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // C#'da char mantığı C++ ile aynıdır.
            char[] isim1 = { 'M', 'u', 's', 't', 'a', 'f', 'a' };
            for (int i = 0; i < 7; i++)
            {
                if (isim1[i] == 'M') isim1[i] = 'm';
                Console.WriteLine(isim1[i]);
            }

            // C#'da string mantığı C++'dan farklıdır. String değişkenine atama yapamayız. |
            string isim2 = "Mustafa";                                                   // |
            for (int i = 0; i < 7; i++)                                                 // |
            {                                                                           // |
                //if (isim2[i] == 'M') isim2[i] = 'm'; isim2 değişkeninin herhangi bir indisine atama yapamadık.
                Console.WriteLine(isim2[i]);
            }
            Console.ReadKey();
            */

            // String Metotları - Karşılaştırmalar
            /*
             * string isim1 = "Mustafa";
             * Console.WriteLine(string.Compare(isim1, "Mustafa"));
             * Console.WriteLine(isim1.CompareTo("Mustafa"));
             * Console.WriteLine(isim1.Equals("Mustafa");
             * Console.WriteLine(isim1 == "Mustafa");
             * Console.WriteLine(isim1.CompareTo("Mus"));
             * string cumle = "eyedipadanadapideye";
             * Console.WriteLine(cumle.
            */

            //
            string isim;
            Console.Write("İsminiz: ");
            isim = Console.ReadLine();
            for (int i = 0; i < isim.Length; i++)
                Console.Write(isim[i] + "-");

            Console.WriteLine();

            foreach (char deger in isim.ToCharArray())
                Console.Write(deger + "-");

            Console.WriteLine();

            foreach (char deger in isim)
                Console.Write(deger + "-");

            Console.WriteLine();

            for (int i = 0; i < isim.Length; i++)
                Console.Write(isim.Substring(i,1) + "-");

            Console.WriteLine();
            // Harf Eksilterek Yazdırma
            for (int i = 0; i < isim.Length; i++)
                Console.WriteLine(isim.Substring(0,isim.Length-i));

            // Harf Çoğaltarak Yazdırma
            for (int i = 0; i <= isim.Length; i++)
                Console.WriteLine(isim.Substring(0, i));

            string json = "{ali,can,cem,dan}";

            for (int i = 1; i < json.Length - 1; i = i + 4)
                Console.WriteLine(json.Substring(i, 3));

            foreach (var isim2 in json.Split(','))
                Console.WriteLine(isim);

            Console.ReadKey();
        }
    }
}
