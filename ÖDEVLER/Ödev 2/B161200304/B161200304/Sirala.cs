using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B161200304
{
    class Sirala
    {
        private int[,] tekrar = new int[5, 2];
        private int[,] farkhesabi;

        public int[,] KBveTekrarSirala(int dongu, int[,] fark_tekrar)
        {
            int[,] gecici = new int[1, 2];
            for (int i = 0; i < dongu; i++)
                for (int j = i + 1; j < dongu; j++)
                    if (fark_tekrar[j, 0] < fark_tekrar[i, 0])
                    {
                        gecici[0, 0] = fark_tekrar[i, 0];
                        gecici[0, 1] = fark_tekrar[i, 1];
                        fark_tekrar[i, 0] = fark_tekrar[j, 0];
                        fark_tekrar[i, 1] = fark_tekrar[j, 1];
                        fark_tekrar[j, 0] = gecici[0, 0];
                        fark_tekrar[j, 1] = gecici[0, 1];
                    }
            return fark_tekrar;
        }

        public void KBSirala()
        {
            Yaz yaz = new Yaz();
            Oku oku = new Oku();
            farkhesabi = new int[yaz.getUretilensayi, 2];
            farkhesabi = KBveTekrarSirala(yaz.getUretilensayi, oku.getFarkhesabi);

            for (int j = 0, k = 0, i = 0; i < 11;)
                if (farkhesabi[i, 1] == (j + 1))
                {
                    tekrar[k, 1] = farkhesabi[i, 1];
                    tekrar[k, 0] += 1;
                    i++;
                    j = 0;
                    k = 0;
                }
                else { j++; k++; }
            tekrar = KBveTekrarSirala(5, tekrar);

            Console.WriteLine("En Fazla Tekrar Eden S Sayısı: " + tekrar[4, 1]);
        }
    }
}
