using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace B161200304
{
    class Oku
    {
        private static int[,] farkhesabi;
        public int[,] getFarkhesabi
        {
            get { return farkhesabi; }
        }
        private int xi, yi, sayac = 0;
        private string okunan;
        private string[] parcalar;

        public void OkuHesapla()
        {
            Yaz yaz = new Yaz();
            Fark fark = new Fark();
            farkhesabi = new int[yaz.getUretilensayi, 2];
            FileStream fsOku = new FileStream("rasgele.txt", FileMode.Open, FileAccess.Read);
            StreamReader Oku = new StreamReader(fsOku);
            try
            {
                okunan = Oku.ReadLine();
                while (okunan != null)
                {
                    parcalar = okunan.Split(' ');
                    
                    xi = (int)Math.Pow(int.Parse(parcalar[0]) - fark.getXyeni, 2);
                    yi = (int)Math.Pow(int.Parse(parcalar[1]) - fark.getYyeni, 2);
                    farkhesabi[sayac, 0] = (int)Math.Sqrt(xi + yi);
                    farkhesabi[sayac, 1] = int.Parse(parcalar[2]);
                    okunan = Oku.ReadLine();
                    sayac++;
                }
            }
            catch (Exception e) { Console.WriteLine(e); }
            finally { Oku.Close(); }
        }
    }
}
