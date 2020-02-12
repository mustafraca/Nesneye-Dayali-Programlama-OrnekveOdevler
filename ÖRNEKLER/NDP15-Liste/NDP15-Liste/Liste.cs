using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP15_Liste
{
    class Liste<T>
    {
        public Liste(int kapasite)
        {
            this.kapasite = kapasite;
            liste = new T[kapasite];
        }
        public Liste() { liste = new T[kapasite]; }
        private T[] liste;
        private int elemansayisi = 0;
        private int kapasite = 5;
        public void Ekle(T eleman)
        {
            if (elemansayisi >= kapasite) Kapasiteartir();
            else liste[elemansayisi++] = eleman;
        }
        public T Getir(int indis)
        {
            return liste[indis];
        }
        public int ElemanSayisi
        {
            get { return elemansayisi; }
        }
        private void Kapasiteartir()
        {
            kapasite *= 2;
            T[] yeniListe = new T[kapasite];
            for (int i = 0; i < elemansayisi; i++)
                yeniListe[i] = liste[i];
            liste = yeniListe;
        }

    }
}
