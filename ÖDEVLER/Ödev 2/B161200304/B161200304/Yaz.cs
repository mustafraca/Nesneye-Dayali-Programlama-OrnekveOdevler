using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace B161200304
{
    class Yaz
    {
        Random rastgele = new Random();
        private static int uretilensayi;
        public int getUretilensayi
        {
            get { return uretilensayi; }
        }
        private int[,] xys;

        public void RandomYaz()
        {
            uretilensayi = rastgele.Next(10, 99);
            xys = new int[uretilensayi, 3];
            FileStream fsYaz = new FileStream("rasgele.txt", FileMode.Create, FileAccess.Write);
            StreamWriter Yaz = new StreamWriter(fsYaz);
            try
            {
                for (int i = 0; i < uretilensayi; i++)
                {
                    xys[i, 0] = rastgele.Next(500, 1000);
                    xys[i, 1] = rastgele.Next(1000, 1500);
                    xys[i, 2] = rastgele.Next(1, 6);
                    Yaz.WriteLine(xys[i, 0] + " " + xys[i, 1] + " " + xys[i, 2]);
                }
            }
            catch (Exception e) { Console.WriteLine(e); }
            finally { Yaz.Close(); }
        }
    }
}
